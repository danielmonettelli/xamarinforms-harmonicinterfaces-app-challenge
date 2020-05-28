using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XF_HarmonicInterfaces.Helpers;
using XF_HarmonicInterfaces.Models;
using XF_HarmonicInterfaces.Utility;

namespace XF_HarmonicInterfaces.ViewModels
{
    public class ExerciseViewModel : MyBaseViewModel
    {
        public ThemeType SelectedTheme;
        public ICommand ExerciseSelectedCommand { get; }
        public ICommand ThemeSelectedCommand { get; }

        private ObservableRangeCollection<Exercise> _exercises;

        public ObservableRangeCollection<Exercise> Exercises
        {
            get => _exercises;
            set
            {
                _exercises = value;
                OnPropertyChanged(nameof(Exercises));
            }
        }

        private Exercise _selectedExercise;

        public Exercise SelectedExercise
        {
            get { return _selectedExercise; }
            set { SetProperty(ref _selectedExercise, value); }
        }

        public ExerciseViewModel()
        {
            Exercises = new ObservableRangeCollection<Exercise>(App.ExerciseDataService.GetAll());

            ExerciseSelectedCommand = new Command(OnExerciseSelectedCommand);

            ThemeSelectedCommand = new Command(OnThemeSelectedCommand);
        }

        private void OnThemeSelectedCommand()
        {
            if(SelectedTheme == ThemeType.Light)
            {
                SelectedTheme = ThemeType.Dark;
            }
            else
            {
                SelectedTheme = ThemeType.Light;
            }

            ThemeHelper.ChangeTheme(SelectedTheme);
        }

        private void OnExerciseSelectedCommand()
        {
            if (SelectedExercise != null)
            {
                App.NavigationService.NavigateTo(ViewNames.ExerciseDetailPage, SelectedExercise);

                SelectedExercise = null;
            }
        }
    }
}
