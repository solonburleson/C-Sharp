using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RapperAPI.Controllers {
    public class GroupController : Controller {
        List<Group> allGroups {get; set;}
        public GroupController() {
            allGroups = JsonToFile<Group>.ReadJson();
        }

        [HttpGet("groups")]
        public IActionResult groups()
        {
            ViewBag.groups = allGroups;
            return View();
        }

        [HttpGet("groups/Name/{name}")]
        public IActionResult byName(string name)
        {
            IEnumerable<Group> byName = allGroups.Where(group => group.GroupName.Contains(name));
            ViewBag.groups = byName;
            return View("groups");
        }

        [HttpGet("groups/GroupId/{id}")]
        public IActionResult byId(int id)
        {
            IEnumerable<Group> byId = allGroups.Where(group => group.Id == id);
            ViewBag.groups = byId;
            return View("groups");
        }
    }
}