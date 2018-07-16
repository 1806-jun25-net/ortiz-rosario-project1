using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Library;
using PizzaStore.Library.Repositories;
using PizzaStoreWebApp.Models;

namespace PizzaStoreWebApp.Controllers
{
    public class UserController : Controller
    {
        public UserRepository User_Repo { get; }

        public UserController(UserRepository user_repo)
        {
            User_Repo = user_repo; 
        }

        // GET: User
        public ActionResult Index([FromQuery] string search = null)
        {
            var libUser = User_Repo.GetUserLastName(search);
            var webUser = libUser.Select(x => new UserModel
            {
               ID = x.Id,
               FirstName = x.FName,
               LastName = x.LName,
               MobileNumber = x.PhoneNumber

            });
            return View(webUser);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var libUser = User_Repo.GetUsersByID(id);
            var webUser = new UserModel
            {
                FirstName = libUser.FName,
                LastName = libUser.LName,
                MobileNumber = libUser.PhoneNumber
                
            };
            return View(webUser);
           
        }

        // GET: User/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserModel user)
        {
            try
            {
               if(ModelState.IsValid)
                {
                    User_Repo.AddUsertoDB(new User
                    {
                        Id = user.ID,
                        FName = user.FirstName,
                        LName = user.LastName,
                        PhoneNumber = user.MobileNumber
                    }); 
                    User_Repo.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(user);
               
            }
           
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            var libUser = User_Repo.GetUsersByID(id);
            var webUser = new UserModel
            {
                ID = libUser.Id,
                FirstName = libUser.FName,
                LastName = libUser.LName,
                MobileNumber = libUser.PhoneNumber
            };
            return View(webUser);
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                User_Repo.DeleteUser(id);
                User_Repo.Save();
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}