using LV2_kusevic_API.Models;
using LV2_kusevic_API.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace LV2_kusevic_API.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        // GET api/contact
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }


    }
}
