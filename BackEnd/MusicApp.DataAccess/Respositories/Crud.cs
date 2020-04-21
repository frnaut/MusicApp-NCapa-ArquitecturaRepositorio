using Core.Models;
using Core.Respositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MusicApp.DataAccess.Respositories
{
    public class Crud<T> : ICrud<T> where T : BasicEntity
    {
        private readonly ApplicationDbContext context;

        public Crud(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task<T> DeleteAsync(int id)
        {
            var model = await context.Set<T>().FirstOrDefaultAsync(x => x.id == id);
            context.Remove(model);
            await context.SaveChangesAsync();
            return model;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var models = await context.Set<T>().ToListAsync();

            return models;
        }

        public async Task<T> GetAsync(int id)
        {
            var model = await context.Set<T>().FirstOrDefaultAsync(x => x.id == id);
            return model;
        }

        public async Task<T> PostAsync(T model)
        {
            var f = await context.Set<T>().AddAsync(model);
            await context.SaveChangesAsync();

            return model;
        }

        public async Task UpdateAsync(int id, T model)
        {
            EntityEntry entity = context.Entry(model);
            entity.State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
