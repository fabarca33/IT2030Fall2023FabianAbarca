using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;
using FabianMusic.Models;
using FabianMusic.Data;

namespace FabianMusic.Models.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List(QueryOptions<T> options);
        T? Get(int id);
        void Insert(T entity);
        void Update(T entity);

        void Delete(T entity);
        void Save();
    }
}
