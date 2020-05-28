using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_HarmonicInterfaces.Helpers;
using XF_HarmonicInterfaces.Themes;
using XF_HarmonicInterfaces.Utility;

namespace XF_HarmonicInterfaces.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExercisePage : ContentPage
    {
        public ExercisePage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.ExerciseViewModel;
        }
    }
}