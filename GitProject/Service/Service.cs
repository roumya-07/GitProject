using GitProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProject.Service
{
    public class Service : IService
    {
        public Task<int> Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<DotNet>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DotNet> GetOne(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(DotNet Dt)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(DotNet Dt)
        {
            throw new NotImplementedException();
        }
    }
}
