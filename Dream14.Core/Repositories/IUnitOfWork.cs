using System;

namespace Dream14.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository Repo { get; }
        IAdminRepository AdminRepo { get; }
        IFrontEndRepository FrontEndRepo { get; }
        IEventRepository EventRepo { get; }

        void BeginTransaction();
        void CommitTransaction();
    }
}
