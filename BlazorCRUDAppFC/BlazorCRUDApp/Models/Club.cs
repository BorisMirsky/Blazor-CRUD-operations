namespace BlazorCRUDApp.Models
{
    public class Club
    {
        public Guid Id { get; set; }
        public string ClubName { get; set; } = String.Empty;
        public string YearFounded { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
    }
}
