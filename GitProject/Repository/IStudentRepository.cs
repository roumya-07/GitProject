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
        Task<DotNet> GetByid(int ID);
        Task<int> Insert(DotNet dot);
        Task<int> Update(DotNet dot);
        Task<int> Delete(int ID);

    }
}
