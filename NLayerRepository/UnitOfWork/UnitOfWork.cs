using NLayerCore.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerRepository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;        
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async void CommitAsync()
        {
           await _context.SaveChangesAsync();
        }

        Task IUnitOfWork.CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
