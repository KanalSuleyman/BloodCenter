using BloodCenter.Application.Repositories.Abstract;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodCenter.Infrastructure.Repositories.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {

        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;

        public UnitOfWork(IConfiguration configuration)
        {
            _connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        private IBloodTestRepository _bloodTestRepository;
        public IBloodTestRepository BloodTests
        {
            get
            {
                if (_bloodTestRepository == null)
                {
                    _bloodTestRepository = new BloodTestRepository(_connection, _transaction);
                }
                return _bloodTestRepository;
            }
        }

        private IRoleRepository _roleRepository;
        public IRoleRepository Roles
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new RoleRepository(_connection, _transaction);
                }
                return _roleRepository;
            }
        }

        public void BeginTransaction()
        {
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _transaction?.Commit();
        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _transaction?.Dispose();
                    _connection?.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
