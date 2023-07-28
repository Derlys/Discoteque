using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

public interface ITourService{

    Task<IEnumerable<Tour>>GetToursAsync();

    Task<Tour>GetById(int id);

    Task<Tour> CreateTour(Tour tour);

    Task<Tour>UpdateTour(Tour tour);
}