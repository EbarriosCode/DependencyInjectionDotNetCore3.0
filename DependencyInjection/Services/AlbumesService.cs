using DependencyInjection.DataContext;
using DependencyInjection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public interface IAlbumesService
    {
        Task<List<Album>> GetAlbumesAsync();
    }
    public class AlbumesService : IAlbumesService
    {
        private readonly WebApiDbContext _context;
        public AlbumesService(WebApiDbContext context) => _context = context;

        public async Task<List<Album>> GetAlbumesAsync()
        {
            var albumes = new List<Album>();

            try
            {
                albumes = await _context.Albumes.Include(a => a.Artista).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return albumes;
        }
    }
}
