using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_HarmonicInterfaces.Utility;

namespace XF_HarmonicInterfaces.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseDetailPage : ContentPage
    {
        public ExerciseDetailPage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.ExerciseDetailViewModel;
        }
    }
}