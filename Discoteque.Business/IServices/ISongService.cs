using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

public interface ISongsService {

    Task<IEnumerable<Song>>GetSongsAsync( );

    Task<Song> GetById(int id);

    Task<Song> CreateSong(Song song);

    Task<Song> UpdateSong(Song song);

    Task<int> DeleteSong(int id);

}