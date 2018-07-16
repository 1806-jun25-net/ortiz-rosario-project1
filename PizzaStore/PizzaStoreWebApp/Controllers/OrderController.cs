using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Data;
using PizzaStore.Library;
using PizzaStore.Library.Repositories;
using PizzaStoreWebApp.Models;

namespace PizzaStoreWebApp.Controllers
{
    public class OrderController : Controller
    {
        public OrderRepository Order_Repo { get; }
       
        public OrderController(OrderRepository order_repo)
        {
            Order_Repo = order_repo;
        }
        // GET: Order
        public ActionResult Index([FromQuery] string search ="")
        {
            //var libOrder = Order_Repo.GetOrders(search);
            //var webOrder = libOrder.Select(x => new OrderModel
            //{
            //    OrderID = x.OrderId
            //});
            return View();  
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            var libOrder = Order_Repo.GetOrdersById(id);
            var webOrder = new OrderModel
            {
                OrderID = libOrder.OrderID,
                OrderTime = libOrder.OrderTime,
                Total_Price = libOrder.Total_Price
            
            };
            return View(webOrder);
        }


        // GET: Order/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderModel order)
        {
           try
            {
                if(ModelState.IsValid)
                {
                    Order_Repo.AddOrder(new PizzaStore.Library.Order
                    {
                        OrderID = order.OrderID,
                        OrderTime = order.OrderTime,
                        Total_Price = order.Total_Price
                        
                    });
                    Order_Repo.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(order);
            }
            catch
            {
                 return View();
            }
           
          
        }

        
        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
           
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(); 
            }
        }
        
        

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            var libOrder = Order_Repo.GetOrdersById(id);
            var webOrder = new OrderModel
            {
                OrderID = libOrder.OrderID,
                OrderTime = libOrder.OrderTime,
                Total_Price = libOrder.Total_Price
            };
            return View(webOrder);
        }

        // POST: Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Order_Repo.DeleteOrder(id);
                Order_Repo.Save(); 
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}