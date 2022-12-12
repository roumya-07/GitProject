using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GitProject.Models;

namespace GitProject.Repository
{
   public interface IStudentRepository
    {
        Task<List<DotNet>> GetAll();
        Task<DotNet> GetByid(int pid);
        Task<int> Insert(DotNet prd);
        Task<int> Update(DotNet prd);
        Task<int> Delete(int id);

    }
}
