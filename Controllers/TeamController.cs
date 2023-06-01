namespace PostgresDb.Controller;

using Microsoft.AspNetCore.Mvc;
using PostgresDb.DTOs;
using PostgresDb.Data;

[ApiController]
[Route("api/team")]
public class TeamController : ControllerBase
{
    private readonly ApiDbContext _context;

    public TeamController(ApiDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAllTeams()
    {
        var team = _context.Teams.ToList();
        Console.WriteLine(team);
        return Ok("team");
    }
    
    [HttpPost]
    public IActionResult CreateTeam(TeamDTO req)
    {
        Console.WriteLine(req);
        return Ok("Team Created");
    }
}