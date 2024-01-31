using Microsoft.AspNetCore.Mvc;
using Mohmed.Models.Data;

namespace Mohmed.Controllers
{
    public class CustmorController : Controller
    {
        public CustmorController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            
        }
        private readonly AppDbContext _appDbContext;
        public IActionResult Index()
        {
            var cusmor=_appDbContext.Cusmors.ToList();
            return View(cusmor);
        }
    }
}
