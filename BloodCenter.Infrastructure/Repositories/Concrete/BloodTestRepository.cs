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
    public class BloodTestRepository : IBloodTestRepository
    {

        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public BloodTestRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public Task<string> AddAsync(BloodTest entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<BloodTest>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BloodTest> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(BloodTest entity)
        {
            throw new NotImplementedException();
        }
    }
}
