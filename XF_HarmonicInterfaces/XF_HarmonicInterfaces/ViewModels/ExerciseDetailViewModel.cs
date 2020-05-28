using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XF_HarmonicInterfaces.Models;
using XF_HarmonicInterfaces.Utility;

namespace XF_HarmonicInterfaces.ViewModels
{
    public class ExerciseDetailViewModel : MyBaseViewModel
    {
        private int _height;

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }

        private Exercise _selectedExercise;

        private ObservableRangeCollection<Session> _sessions;

        public ObservableRangeCollection<Session> Sessions
        {
            get => _sessions;
            set
            {
                _sessions = value;
                Height = (_sessions.Count * 40) + (_sessions.Count * 10);
                OnPropertyChanged(nameof(Sessions));
            }
        }

        public ExerciseDetailViewModel()
        {
            SelectedExercise = new Exercise();

            Sessions = new ObservableRangeCollection<Session>(App.SessionDataService.GetAll());
        }

        public Exercise SelectedExercise
        {
            get { return _selectedExercise; }
            set
            {
                _selectedExercise = value;
                OnPropertyChanged(nameof(SelectedExercise));
            }
        }

        public override void Initialize(object parameter)
        {
            if (parameter == null)
            {
                SelectedExercise = new Exercise();
            }
            else
            {
                SelectedExercise = parameter as Exercise;
            }
        }
    }
}
