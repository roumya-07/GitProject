using Dapper;
using GitProject.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GitProject.Repository
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public StudentRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> Delete(int ID)
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@ID", ID);
                param.Add("@action", "Delete");
                var x = cn.Execute("SP_DotNet", param, commandType: CommandType.StoredProcedure);
                cn.Close();
                return x;
            }

            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<List<DotNet>> GetAll()
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "All");
                var x = cn.Query<DotNet>("SP_DotNet", param, commandType: CommandType.StoredProcedure).ToList();
                cn.Close();
                return x;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<DotNet> GetByid(int ID)
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@ID", ID);
                param.Add("@action", "SelectOne");
                var x = cn.Query<DotNet>("SP_DotNet", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                cn.Close();
                return x;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> Insert(DotNet dot)
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@ID", dot.ID);
                param.Add("@Name", dot.Name);
                param.Add("@Phone", dot.Phone);
                param.Add("@Address", dot.Address);
                param.Add("@action", "Insert");
                var x = cn.Execute("SP_DotNet", param, commandType: CommandType.StoredProcedure);
                cn.Close();
                return x;
            }

            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> Update(DotNet dot)
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@ID", dot.ID);
                param.Add("@Name", dot.Name);
                param.Add("@Phone", dot.Phone);
                param.Add("@Address", dot.Address);
                param.Add("@action", "Update");
                var x = cn.Execute("SP_DotNet", param, commandType: CommandType.StoredProcedure);
                cn.Close();
                return x;
            }

            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
