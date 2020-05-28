using System;
using System.Collections.Generic;
using System.Text;
using XF_HarmonicInterfaces.Models;

namespace XF_HarmonicInterfaces.Services
{
    public interface IModelDataService<Model> where Model : class
    {
        List<Model> GetAll();

        void Add(Model model);

        void Update(Model model);

        void Remove(Model model);
    }
}
