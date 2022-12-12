using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GitProject.Models;

namespace GitProject.Services
{
   public interface IService
    {
        Task<List<DotNet>> GetAll();
        Task<DotNet> GetOne(int ID);
        Task<int> Insert(DotNet Dt);
        Task<int>Update(DotNet Dt);
        Task<int> Delete(int ID);
    }
}
