using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumesController : ControllerBase
    {
        private readonly IAlbumesService _albumesService;
        public AlbumesController(IAlbumesService albumesService) => _albumesService = albumesService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var albumes = await _albumesService.GetAlbumesAsync();
            return Ok(albumes);
        }
    }
}