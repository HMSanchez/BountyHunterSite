using BountyHunterBrowser.Models;
using BountyHunterLib.Model;
using BountyHunterLib.Service;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BountyHunterBrowser.Controllers
{
    public class HunterController : Controller
    {
        static HunterModel placeholder = null;

        UserModelList ul = new UserModelList();
        IBountyHunterService service = new BountyHunterService();
        public ActionResult Index()
        {
            HunterListModel model = service.GetAllHunters();

            return View(model);
        }

        public ActionResult HunterDetail(int id)
        {
            HunterModel model = service.GetHunterById(id);
            return View(model);
        }

        public ActionResult HunterCatalog()
        {
            HunterListModel model = service.GetAllHunters();


            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult AddHunter(HunterModel hunterModel)
        {
            if (ModelState.IsValid)
            {
                service.AddNewHunter(hunterModel);
                HunterListModel model = service.GetAllHunters();

                return View("HunterCatalog", model);
            }
            else
            {
                return View();
            }


        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult EditHunter(int id)
        {



            var BHunter = service.GetHunterById(id);
            // service.UpdateHunter(id);

            //HunterListModel model = service.GetAllHunters();

            return View(BHunter);


        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult EditHunter(HunterModel BHunter)
        {



            //var BHunter = service.GetHunterById(id); 
            service.UpdateHunter(BHunter);

            //HunterListModel model = service.GetAllHunters();


            return View("HunterDetail", BHunter);

        }

        [Authorize(Roles = "Admin")]
        public ActionResult DeleteHunter(int id)
        {
            //HunterModel model = service.GetHunterById(id);
            if (ModelState != null)
            {
                service.DeleteHunterById(id);
                HunterListModel model = service.GetAllHunters();

                return View("HunterCatalog", model);
            }
            else
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        public ActionResult GetRoles()
        {

            ApplicationDbContext context = new ApplicationDbContext();

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //var roles = context.Roles;

            //var rolesList = roles.ToList();
            //var userList = context.Users.ToList();

            //userList.ForEach(hunter =>
            //{
            //    ul.UserModelsList.Add(

            //        new UserModel()
            //        {
            //            user = hunter.;
            //            roles = hunter.Roles.ToList();
            //        }

            //        );
            //});

            var userRoles = new List<RolesViewModel>();

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            //Get all the usernames
            foreach (var user in userStore.Users)
            {
                var r = new RolesViewModel
                {
                    UserName = user.UserName
                };
                userRoles.Add(r);
            }
            //Get all the Roles for our users
            foreach (var user in userRoles)
            {
                user.RoleNames = userManager.GetRoles(userStore.Users.First(s => s.UserName == user.UserName).Id);
            }

            return View(userRoles);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Promote()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            
            //UserManager.AddToRole( "Admin");
            UserManager.AddToRole(Request.Form["userId"], "Admin");
            context.SaveChanges();

            return RedirectToAction("ViewRoles", "Hunter");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Demote()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            UserManager.RemoveFromRole(Request.Form["userId"], "Admin");
            //UserManager.AddToRole( "Admin");
            context.SaveChanges();
            //UserManager.AddToRole(Request.Form["userId"], "Admin");
            return RedirectToAction("ViewRoles", "Hunter");
        }

        [Authorize(Roles = "Admin")]
        public ViewResult ViewRoles()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var listOfUsers = (from u in db.Users
                               let query = (from ur in db.Set<IdentityUserRole>()
                                            where ur.UserId.Equals(u.Id)
                                            join r in db.Roles on ur.RoleId equals r.Id
                                            select r.Name)
                               select new UserRoleInfo() { User = u, Roles = query.ToList<string>() })
                         .ToList();

            return View(listOfUsers);
        }



        public ViewResult LastView()
        {

            return View();
        }
    }
}