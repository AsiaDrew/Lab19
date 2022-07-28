using DESIGNING_AND_CREATING_A_REST_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DESIGNING_AND_CREATING_A_REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        public NorthwindContext northwindcontext = new NorthwindContext();

        [HttpGet("GetByShipperId")]
        public Shipper GetByShipperId(int id)
        {
            return northwindcontext.Shippers.FirstOrDefault(s => s.ShipperId == id);
        }

        [HttpGet("GetByCompanyName")]
        public Shipper GetByShipperName(string name)
        {
            return northwindcontext.Shippers.FirstOrDefault(s => s.CompanyName == name);
        }

        [HttpPost("AddShipper")]
        public Shipper AddShipper(string companyName, string phone)
        {
            Shipper addShipper = new Shipper()
            {
                CompanyName = companyName,
                Phone = phone
            };
            northwindcontext.Shippers.Add(addShipper);
            northwindcontext.SaveChanges();
            return addShipper;
        }

        [HttpDelete("RemoveShipper")]
        public Shipper DeleteById(int id)
        {
            Shipper removedShipper = northwindcontext.Shippers.FirstOrDefault(s => s.ShipperId == id);
            northwindcontext.Shippers.Remove(removedShipper);
            northwindcontext.SaveChanges();
            return removedShipper;
        }

        [HttpPost("PutShipper")]
        public Shipper PutShipper(int id, string companyName, string phone)
        {
            Shipper currShipper = northwindcontext.Shippers.FirstOrDefault(s => s.ShipperId == id);
            if (currShipper != null)
            {
                currShipper.CompanyName = companyName;
                currShipper.Phone = phone;

                northwindcontext.SaveChanges();
            }
            return currShipper;
        }
    }
}