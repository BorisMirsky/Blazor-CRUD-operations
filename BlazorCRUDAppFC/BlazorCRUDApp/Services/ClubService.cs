using BlazorCRUDApp.Models;
using Microsoft.EntityFrameworkCore;



namespace BlazorCRUDApp.Services
{
    public class ClubService : IClubService
    {
        private readonly ClubDbContext _context;

        public ClubService(ClubDbContext context)
        {
            _context = context;
        }

        public async Task<List<Club>> GetClubs()
        {
            return await _context.Clubs.ToListAsync();
        }

        public async Task<Club> GetClub(Guid id)
        {
            var club = await _context.Clubs.FindAsync(id);
            if (club == null)
            {
                throw new Exception("club not found");
            }
            return club;
        }

        public async Task AddClub(Club club)
        {
            _context.Clubs.Add(club);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClub(Club club)
        {
            _context.Entry(club).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClub(Guid id)       
        {
            var club = await _context.Clubs.FindAsync(id);
            if (club != null)
            {
                _context.Clubs.Remove(club);
                await _context.SaveChangesAsync();
            }
        }
    }
}
