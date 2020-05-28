using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace XF_HarmonicInterfaces.Models
{
    public static class ExerciseRepository
    {
        static ExerciseRepository()
        {
            if (Exercises == null)
            {
                Exercises = new List<Exercise>
                {
                    new Exercise
                    {
                        Id_Exercise = Guid.Parse("{70822596-265D-49E3-8CCC-CD996093E601}"),
                        Name_Exercise = "Diet Recommendation",
                        Image_Exercise = "resource://XF_HarmonicInterfaces.SVGImages.svg_hamburger.svg",
                        Duration_Exercise = "15-55 MIN Course",
                        Description_Exercise = "Learn how to Create Your Clients(or your)perfect diet and nutrition plan based on their goals, preferences and lifestyle"
                    },
                    new Exercise
                    {
                        Id_Exercise = Guid.Parse("{11DB10F5-C461-490F-A7A3-5BA5AF3A58AF}"),
                        Name_Exercise = "Kegel Exercises",
                        Image_Exercise = "resource://XF_HarmonicInterfaces.SVGImages.svg_exercises.svg",
                        Duration_Exercise = "5-35 MIN Course",
                        Description_Exercise = "Kegel exercises can prevent or control urinary incontinence and other pelvic floor problems. Here's a step-by-step guide to doing Kegel exercises correctly."
                    },
                    new Exercise
                    {
                        Id_Exercise = Guid.Parse("{0AC44F1C-84FB-4BCC-8E1F-49FCC8F2A17C}"),
                        Name_Exercise = "Meditation",
                        Image_Exercise = "resource://XF_HarmonicInterfaces.SVGImages.svg_meditation.svg",
                        Duration_Exercise = "3-10 MIN Course",
                        Description_Exercise = "Live happier and healthier by learning the fundamentals of meditation and mindfulness"
                    },
                    new Exercise
                    {
                        Id_Exercise = Guid.Parse("{27629374-72AA-40CC-9819-993440356585}"),
                        Name_Exercise = "Yoga",
                        Image_Exercise = "resource://XF_HarmonicInterfaces.SVGImages.svg_meditating.svg",
                        Duration_Exercise = "12-125 MIN Course",
                        Description_Exercise = "Experience healing benefits from your yoga poses by mindfully aligning your body the right way"
                    }

                };
            }
        }

        public static List<Exercise> Exercises { get; set; }

        public static void AddExercise(Exercise exercise)
        {
            
        }

        public static void UpdateExercise(Exercise exercise)
        {
         
        }

        public static void RemoveExercise(Exercise exercise)
        {
          
        }
    }
}
