using System.Collections.Generic;
namespace School_Management.Repository
{
    public interface IGenericRepository<T> where T : class
    {
         void saveData(T obj);
         List<T> getData();
         void deleteData(T obj);
         void updateData(T obj);
    }
}