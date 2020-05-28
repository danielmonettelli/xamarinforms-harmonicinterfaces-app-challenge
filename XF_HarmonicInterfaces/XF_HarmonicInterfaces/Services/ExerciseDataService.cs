using System;
using System.Collections.Generic;
using System.Text;
using XF_HarmonicInterfaces.Models;

namespace XF_HarmonicInterfaces.Services
{
    public class ExerciseDataService : IModelDataService<Exercise>
    {
        public void Add(Exercise model)
        {
            throw new NotImplementedException();
        }

        public List<Exercise> GetAll()
        {
            return ExerciseRepository.Exercises;
        }

        public void Remove(Exercise model)
        {
            throw new NotImplementedException();
        }

        public void Update(Exercise model)
        {
            throw new NotImplementedException();
        }
    }
}
