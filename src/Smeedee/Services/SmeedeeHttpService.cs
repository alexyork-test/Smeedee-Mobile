using System;
using System.Collections.Generic;
using Smeedee.Model;

namespace Smeedee.Services
{
    public class SmeedeeHttpService : ISmeedeeService
    {
        public SmeedeeHttpService()
        {
        }
        
        public void LoadTopCommiters(Action<AsyncResult<IEnumerable<Commiter>>> callback)
        {
            throw new NotImplementedException();
        }
    }
}
