using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vibe.Models;

namespace Vibe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["BandMembers"] = new List<BandMember>();
            ViewData["BandMembers"] = CreateBandMembersVibe();
            return View();
        }

        private List<BandMember> CreateBandMembersVibe()
        {
            BandMember Zsolt = new BandMember("Zsolt", "Rónai", "Gitár", "/Content/Images/bandmember.jpg");
            BandMember Zoli = new BandMember("Zoltán", "Papp",  "Basszusgitár", "/Content/Images/bandmember.jpg");
            BandMember Szumpi = new BandMember("Ákos", "Szumper", "Dob", "/Content/Images/bandmember.jpg");
            BandMember Olivér = new BandMember("Olivér", "Kocsis", "Billentyű", "/Content/Images/bandmember.jpg");
            return new List<BandMember> { Zsolt, Zoli, Szumpi, Olivér };
        }
    }
}