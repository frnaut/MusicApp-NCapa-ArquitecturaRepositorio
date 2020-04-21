using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Respositories
{
    public interface ICrud<T> where T : BasicEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<T> PostAsync(T model);
        Task UpdateAsync(int id, T model);
        Task<T> DeleteAsync(int id); 
    }
}
