using XF_HarmonicInterfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace XF_HarmonicInterfaces.Utility
{
    public static class ViewModelLocator
    {
        public static ExerciseViewModel ExerciseViewModel { get; set; } 
            = new ExerciseViewModel();

        public static ExerciseDetailViewModel ExerciseDetailViewModel { get; set; }
           = new ExerciseDetailViewModel();
    }
}
