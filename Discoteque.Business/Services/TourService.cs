using Discoteque.Business.IServices;
using Discoteque.Data;
using Discoteque.Data.Models; 

namespace Discoteque.Business.Services;

public class TourService : ITourService{
    private IUnitOfWork _unitOfWork;

    public TourService(IUnitOfWork unitOfWork){
        _unitOfWork = unitOfWork;
    }

    public async Task<Tour> CreateTour (Tour tour){
        await _unitOfWork.TourRepository.AddAsync(tour);
        await _unitOfWork.SaveAsync();
        return tour;
    }

    public async Task<Tour> GetById(int id){
        return await _unitOfWork.TourRepository.FindAsync(id);
    }

    public async Task<IEnumerable<Tour>> GetToursAsync(){
        return await _unitOfWork.TourRepository.GetAllAsync();
    }

    public async Task<Tour> UpdateTour (Tour tour){
        await _unitOfWork.TourRepository.Update(tour);
        await _unitOfWork.SaveAsync();
        return tour;
    }
}