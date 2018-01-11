using Domain.Repository.Abstract;
using System;

namespace Domain.UnitofWork
{
  public interface IUnitOfWork : IDisposable
  {
    ICamaRepository CamaRepository { get; }

    new void Dispose();
  }
}
