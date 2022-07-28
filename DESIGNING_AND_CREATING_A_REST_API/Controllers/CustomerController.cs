using DESIGNING_AND_CREATING_A_REST_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DESIGNING_AND_CREATING_A_REST_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public NorthwindContext northwindcontext = new NorthwindContext();

        [HttpGet("GetByCustomerId")]
        public Customer GetById(string id)
        {
            return northwindcontext.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        [HttpGet("GetByCompanyName")]
        public Customer GetByCompanyName(string name)
        {
            return northwindcontext.Customers.FirstOrDefault(c => c.CompanyName == name);
        }

        [HttpGet("GetByContactName")]
        public Customer GetByContactName(string contact)
        {
            return northwindcontext.Customers.FirstOrDefault(c => c.ContactName == contact);
        }

        [HttpPost("AddCustomer")]
        public Customer AddCustomer(string customerId, string companyName, string contactName, string contactTitle,
            string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            Customer addedd = new Customer()
            {
                CustomerId = customerId,
                CompanyName = companyName,
                ContactName = contactName,
                ContactTitle = contactTitle,
                Address = address,
                City = city,
                Region = region,
                PostalCode = postalCode,
                Country = country,
                Phone = phone,
                Fax = fax
            };
            northwindcontext.Customers.Add(addedd);
            northwindcontext.SaveChanges();
            return addedd;
        }

        [HttpPatch("UpdateContactName")]
        public Customer UpdateContactName(string id, string contactName)
        {
            Customer updateContact = northwindcontext.Customers.FirstOrDefault(c => c.CustomerId == id);
            updateContact.ContactName = contactName;
            northwindcontext.Customers.Update(updateContact);
            northwindcontext.SaveChanges();
            return updateContact;
        }

        [HttpPatch("UpdateContactTitle")]
        public Customer UpdateContactTitle(string id, string contactTitle)
        {
            Customer updateTitle = northwindcontext.Customers.FirstOrDefault(c => c.CustomerId == id);
            updateTitle.ContactTitle = contactTitle;
            northwindcontext.Customers.Update(updateTitle);
            northwindcontext.SaveChanges();
            return updateTitle;
        }

    }
}