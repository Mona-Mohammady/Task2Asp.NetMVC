using Microsoft.AspNetCore.Mvc;
using Task1Asp.NetMVC.Models;

namespace Task1Asp.NetMVC.Controllers
{
    public class PartyController : Controller
    {
        public IActionResult PartyPage()
        {
            return View("Home");
        }

        //Party/GuestForm
        public IActionResult GuestForm()
        {
            return View("GuestForm");
        }


        public IActionResult GuestList(Guestes _guest)
        {
            List<Guestes> li = SampleData.getGuests();
            SampleData.AddGuest(_guest);
            return View("GuestList",li );
            
        }


    }
}
