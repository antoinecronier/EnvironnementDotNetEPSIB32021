using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [HttpGet]
        public String Index()
        {
            return "bonjour";
        }

        [HttpPost]
        public String Index1()
        {
            return "bonjour1";
        }

        [HttpGet]
        public User Index2()
        {
            return new User() { Id = 0, Firstname = "me", Lastname = "C" };
        }

        [HttpGet]
        // http://localhost:52420/Default/Request1?test=%22bonjour%22&test2=230&test3=true&test1=null
        public String Request1(String test, String test1, int? test2, bool? test3)
        {
            return test + test1 + test2 + test3;
        }

        [HttpGet]
        // http://localhost:52420/Default/Request2?Id=10&Firstname=UserFirstname&Lastname=test
        // http://localhost:52420/Default/Request2?Id=10&CurrentRole.Name=myName&Roles[0].Name=r2&Roles[0].Id=23&Roles[1].Name=r2&Roles[2].Id=2
        public User Request2(User user)
        {
            return user;
        }

        [HttpGet]
        // http://localhost:52420/Default/Request3?Id=10&Firstname=UserFirstname&Lastname=10
        public User Request3(User user, String Firstname, int Lastname)
        {
            return user;
        }

        [HttpGet]
        // http://localhost:52420/Default/Request4?user.Id=10&Firstname=UserFirstname&Lastname=10&user.Firstname=f1&user.Lastname=l1
        public String Request4(User user, User user1)
        {
            return user.ToString() + user1.ToString();
        }

        [HttpPost]
        public User Request5(User user)
        {
            return user;
        }

        [HttpPost]
        public User Request6(User user, string id)
        {
            return user;
        }

        public ActionResult ShowView()
        {
            ViewBag.Test = "ceci est un test";
            ViewBag.User = new User() { Id = 10, Firstname = "Fname", Lastname = "Lname", CurrentRole = new Role() { Id = 1, Name = "role1" } };
            //return View("~/Default/ShowView");
            return View();
        }
    }
}