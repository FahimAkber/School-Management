using System.Collections.Generic;
using System.Linq;
using School_Management.Models;
using Microsoft.EntityFrameworkCore;
namespace School_Management.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public SchoolContext context;
        private DbSet<T> table;

        public GenericRepository(){
            context = new SchoolContext();
            table = context.Set<T>();
        }

        public void saveData(T obj){
            table.Add(obj);
            context.SaveChanges();
        }
        public List<T> getData(){
            return table.ToList();
        }
        public void deleteData(T obj){
            table.Remove(obj);
            context.SaveChanges();
        }
        public void updateData(T obj){
            table.Update(obj);
            context.SaveChanges();
            
        }
    }
}