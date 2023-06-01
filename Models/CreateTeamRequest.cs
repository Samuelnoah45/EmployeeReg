namespace PostgresDb.Models
{
    public class CreateTeamRequest
    {
        public string Name { get; set; }
        public int Year { get; set; } = 2023;
    }
}