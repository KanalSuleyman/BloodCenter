using BloodCenter.Application.Repositories.Abstract;
using BloodCenter.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodCenter.Infrastructure.Repositories.Concrete
{
    public class RoleRepository : IRoleRepository
    {

        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public RoleRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public Task<string> AddAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Role>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
