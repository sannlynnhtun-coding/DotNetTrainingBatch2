using System.Text.Json;
using DotNetTrainingBatch2.RealtimeChartUsingSignalR.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch2.RealtimeChartUsingSignalR.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHubContext<TeamHub> _hubContext;

        public TeamController(AppDbContext context, IHubContext<TeamHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        [ActionName("Index")]
        public IActionResult TeamIndex()
        {
            return View("TeamIndex");
        }

        [ActionName("Create")]
        public IActionResult TeamCreate()
        {
            return View("TeamCreate");
        }

        [ActionName("Save")]
        public async Task<IActionResult> TeamSave(TeamDataModel team)
        {
            await _context.AddAsync(team);
            await _context.SaveChangesAsync();

            var lst = await _context.Teams
                .AsNoTracking()
                .ToListAsync();

            var data = new
            {
                Series = lst.Select(x=> x.Score).ToList(),
                Labels = lst.Select(x => x.TeamName).ToList()
            };

            string json = JsonSerializer.Serialize(data);
            await _hubContext.Clients.All.SendAsync("ReceiveTeamClientEvent", json);

            return Redirect("/Team/Create");
        }
    }
}
