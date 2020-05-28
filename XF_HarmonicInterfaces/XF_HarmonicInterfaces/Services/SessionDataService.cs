using System;
using System.Collections.Generic;
using System.Text;
using XF_HarmonicInterfaces.Models;

namespace XF_HarmonicInterfaces.Services
{
    public class SessionDataService : IModelDataService<Session>
    {
        public void Add(Session model)
        {
            throw new NotImplementedException();
        }

        public List<Session> GetAll()
        {
            return SessionRepository.Sessions;
        }

        public void Remove(Session model)
        {
            throw new NotImplementedException();
        }

        public void Update(Session model)
        {
            throw new NotImplementedException();
        }
    }
}
