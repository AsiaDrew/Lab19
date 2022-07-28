using DESIGNING_AND_CREATING_A_REST_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DESIGNING_AND_CREATING_A_REST_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public NorthwindContext northwindcontext = new NorthwindContext();

        [HttpGet("GetByOrderId")]
        public Order GetById(int id)
        {
            return northwindcontext.Orders.Include(o => o.Customer).FirstOrDefault(o => o.OrderId == id);
        }

        [HttpGet("GetByCustomerId")]
        public List<Order> GetByCustId(string id)
        {
            return northwindcontext.Orders.Where(p => p.CustomerId == id).ToList();
        }
    }
}