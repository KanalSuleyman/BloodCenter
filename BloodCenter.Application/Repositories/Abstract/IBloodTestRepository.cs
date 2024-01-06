using BloodCenter.Core.Entities.Concrete;
using BloodCenter.Shared.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodCenter.Application.Repositories.Abstract
{
    public interface IBloodTestRepository : IEntityRepository<BloodTest>
    {
    }
}
