using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross;
using TestApp123.Core.DAL;

namespace TestApp123.Core.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private Context _db;
        public UnitOfWork(Context db)
        {
            _db = db;
        }

        public T GetRepository<T>() where T : class
        {
            var repo = Mvx.IoCProvider.IoCConstruct<T>(_db);
            return repo;
        }
    }
}
