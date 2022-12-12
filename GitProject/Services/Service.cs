using GitProject.Models;
using GitProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProject.Services
{
    public class Service : IService
    {
        private readonly IStudentRepository _Repository;

        public Service(IStudentRepository Repository)
        {
            _Repository = Repository;
        }
        public async Task<int> Delete(int ID)
        {
            return await _Repository.Delete(ID);
        }

        public async Task<List<DotNet>> GetAll()
        {
            return await _Repository.GetAll();
        }

        public async Task<DotNet> GetOne(int ID)
        {
            return await _Repository.GetByid(ID);
        }

        public async Task<int> Insert(DotNet Dt)
        {

            return await _Repository.Insert(Dt);
        }

        public async Task<int> Update(DotNet Dt)
        {
            return await _Repository.Update(Dt);
        }
    }
}
