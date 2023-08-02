using Microsoft.AspNetCore.Mvc;

namespace Respiro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicalSessionsController
    {
        private readonly MyDbContext _context;

        public MedicalSessionsController(MyDbContext context)
        {
            _context = context;
        }
    }
}
