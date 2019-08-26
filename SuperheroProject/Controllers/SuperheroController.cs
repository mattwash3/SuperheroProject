using SuperheroProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroProject.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext context;

        //public string allHeroes;
        public SuperheroController()
        {
            context = new ApplicationDbContext();
        }

        // GET: SuperheroallHeroes
        public ActionResult Index()
        {
            var allHeroes = context.Superheroes.ToList();
            return View(allHeroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            Superhero superheroView = context.Superheroes.Where(s => s.Id == id).Single();
            return View(superheroView);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superheroToUpdate = context.Superheroes.Where(s => s.Id == id).Single();
            return View(superheroToUpdate);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                Superhero superheroToUpdate = context.Superheroes.Where(s => s.Id == id).Single();
                superheroToUpdate.superheroName = superhero.superheroName;
                superheroToUpdate.alterEgoFirstName = superhero.alterEgoFirstName;
                superheroToUpdate.alterEgoLastName = superhero.alterEgoLastName;
                superheroToUpdate.primaryAbility = superhero.primaryAbility;
                superheroToUpdate.secondaryAbility = superhero.secondaryAbility;
                superheroToUpdate.catchphrase = superhero.catchphrase;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superheroToDelete = context.Superheroes.Where(s => s.Id == id).Single();
            return View(superheroToDelete);
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here  
                Superhero superheroToDelete = context.Superheroes.Where(s => s.Id == id).Single();
                context.Superheroes.Remove(superheroToDelete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
