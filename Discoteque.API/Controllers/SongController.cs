using Microsoft.AspNetCore.Mvc;
using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.API.Controllers{

    [Route("api/[controller]")]
    [ApiController]

    public class SongsController : ControllerBase{

        private readonly ISongsService _songsService;

        public SongsController(ISongsService songsService){
            _songsService = songsService;
        }

        [HttpGet]
        [Route("GetAllSongsAsync")]

        public async Task<IActionResult> GetAllSongsAsync()
        {
            var songs = await _songsService.GetSongsAsync();
            return Ok(songs);
        }

        [HttpPost]
        [Route("CreateSongAsync")]

        public async Task<IActionResult> CreateSongAsync(Song song){
            var result = await _songsService.CreateSong(song);
            return Ok(result);
        }

        [HttpPatch]
        [Route("UpdateSongAsync")]

        public async Task<IActionResult> UpdateSongAsync(Song song ){
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteSongAsync")]

        public async Task<IActionResult> DeleteSongAsync (int id){
            return Ok();
        }

    }
}