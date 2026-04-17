using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiderController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            user.UserType = "rider";
            return Ok(user);
        }

        [HttpPost("book-ride")]
        public IActionResult AcceptRide(Ride ride)
        {
            ride.Status = "requested";
            return Ok(ride);
        }
    }
}
