using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XF_HarmonicInterfaces.Services;
using XF_HarmonicInterfaces.Utility;
using XF_HarmonicInterfaces.Views;

namespace XF_HarmonicInterfaces
{
    public partial class App : Application
    {
        public static ExerciseDataService ExerciseDataService { get; } = new ExerciseDataService();
        public static SessionDataService SessionDataService { get; } = new SessionDataService();
        public static NavigationService NavigationService { get; } = new NavigationService();

        public App()
        {
            InitializeComponent();

            NavigationService.Configure(ViewNames.ExercisePage, typeof(ExercisePage));
            NavigationService.Configure(ViewNames.ExerciseDetailPage, typeof(ExerciseDetailPage));

            MainPage = new AppShell();
            //MainPage = new NavigationPage(new ExercisePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
