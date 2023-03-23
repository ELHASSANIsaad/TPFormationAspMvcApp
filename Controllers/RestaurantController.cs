using FormationAspMvcApp.Data;
using FormationAspMvcApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace FormationAspMvcApp.Controllers
{
    public class RestaurantController : Controller
    {

        //List<Restaurant> restaurants = new List<Restaurant>(){
        //            new Restaurant(1, "PizzaHut","Rabat","Open"),
        //          new Restaurant(2, "KFC","Rabat","Open"),
        //          new Restaurant(1, "Suchi","casa","Open"),
        //          new Restaurant(2, "MacDonalds","Tanger","Open"),

        //        };


        private readonly IRepository _restaurantRepository;


      
        public RestaurantController(IRepository customerRepository)
        {
            _restaurantRepository = customerRepository;
        }


        string myName = "test bag data binding";

        [ResponseHeaderAttributecs("correlation-id", "Example")]
        //testing routes
        [Route("/testroute")]
        public ActionResult TestRoute()
        {
            return RedirectToAction(nameof(Index));
        }


        //


        // GET: RestaurantController
        public ActionResult Index()
        {


 
  
            var restauList = _restaurantRepository.GetAll();
            ViewBag.TotalRestaurent = restauList.Count();

            return View(restauList);

            //return View();
        }

        // GET: RestaurantController/Details/5
        public ActionResult Details(int id)
        {
            
            var restaurant = _restaurantRepository.GetById(id);

            return View(restaurant);
        }

        // GET: RestaurantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RestaurantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            try
            {
                _restaurantRepository.Add(restaurant);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



    // GET: RestaurantController/Edit/5
    public ActionResult Edit(int id)
        {
            var restaurant = _restaurantRepository.GetById(id);

            return View(restaurant);
        }

        // POST: RestaurantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
        {
            try
            {
                _restaurantRepository.Update(restaurant);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestaurantController/Delete/5
        public ActionResult Delete(int id)
        {
            var restaurant = _restaurantRepository.GetById(id);

            return View(restaurant);
        }

        // POST: RestaurantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Restaurant restaurant)
        {


                return RedirectToAction(nameof(Index));
           
        }
    }
}
