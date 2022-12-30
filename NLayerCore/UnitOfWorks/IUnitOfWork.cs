using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.UnitOfWorks
{
    public interface IUnitOfWork
    {
        void CommitAsync();
        void Commit();
    }
}
