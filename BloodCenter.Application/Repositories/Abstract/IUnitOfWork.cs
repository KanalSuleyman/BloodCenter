using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodCenter.Application.Repositories.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IBloodTestRepository BloodTests { get; }
        IRoleRepository Roles { get; }

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
