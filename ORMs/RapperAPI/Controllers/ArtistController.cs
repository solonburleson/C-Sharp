using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RapperAPI.Controllers {

    
    public class ArtistController : Controller {

        private List<Artist> allArtists;

        public ArtistController() {
            allArtists = JsonToFile<Artist>.ReadJson();
        }

        //This method is shown to the user navigating to the default API domain name
        //It just display some basic information on how this API functions
        [Route("")]
        [HttpGet]
        public string Index() {
            //String describing the API functionality
            string instructions = "Welcome to the Music API~~\n========================\n";
            instructions += "    Use the route /artists/ to get artist info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *RealName/{string}\n";
            instructions += "       *Hometown/{string}\n";
            instructions += "       *GroupId/{int}\n\n";
            instructions += "    Use the route /groups/ to get group info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *GroupId/{int}\n";
            instructions += "       *ListArtists=?(true/false)\n";
            return instructions;
        }

        [HttpGet("artists")]
        public IActionResult artists()
        {
            ViewBag.artists = allArtists;
            return View();
        }

        [HttpGet("artists/Name/{name}")]
        public IActionResult byName(string name)
        {
            IEnumerable<Artist> byName = allArtists.Where(artist => artist.ArtistName.Contains(name));
            ViewBag.artists = byName;
            return View("artists");
        }

        [HttpGet("artists/RealName/{name}")]
        public IActionResult byRealName(string name)
        {
            IEnumerable<Artist> byRealName = allArtists.Where(artist => artist.RealName.Contains(name));
            ViewBag.artists = byRealName;
            return View("artists");
        }

        [HttpGet("artists/Hometown/{city}")]
        public IActionResult byCity(string city)
        {
            IEnumerable<Artist> byCity = allArtists.Where(artist => artist.Hometown.Contains(city));
            ViewBag.artists = byCity;
            return View("artists");
        }

        [HttpGet("artists/GroupId/{id}")]
        public IActionResult byGroupId(int id)
        {
            IEnumerable<Artist> byGroupId = allArtists.Where(artist => artist.GroupId == id);
            ViewBag.artists = byGroupId;
            return View("artists");
        }
    }
}