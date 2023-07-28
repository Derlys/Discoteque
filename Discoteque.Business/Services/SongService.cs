using Discoteque.Business.IServices;
using Discoteque.Data;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class SongsService : ISongsService
{
    private IUnitOfWork _unitOfWork;

    public SongsService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Song> CreateSong (Song song)
    {
        await _unitOfWork.SongRepository.AddAsync(song);
        await _unitOfWork.SaveAsync();
        return song;
    }

    public async Task<int> DeleteSong (int id){
        await _unitOfWork.SongRepository.Delete(id);
        await _unitOfWork.SaveAsync();
        return id;
    }

    public async Task<Song> GetById(int id){
        return await _unitOfWork.SongRepository.FindAsync(id);
    }

    public async Task<IEnumerable<Song>> GetSongsAsync(){
        return await _unitOfWork.SongRepository.GetAllAsync();
    }

    public async Task<Song> UpdateSong (Song song){
        await _unitOfWork.SongRepository.Update(song);
        await _unitOfWork.SaveAsync();
        return song;
    }
}