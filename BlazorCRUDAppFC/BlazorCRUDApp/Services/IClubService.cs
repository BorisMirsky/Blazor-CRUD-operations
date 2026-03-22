using BlazorCRUDApp.Models;

namespace BlazorCRUDApp.Services
{
    public interface IClubService
    {
        Task<List<Club>> GetClubs();
        Task<Club> GetClub(Guid id);
        Task AddClub(Club club);
        Task UpdateClub(Club club);
        Task DeleteClub(Guid id);         
    }
}
