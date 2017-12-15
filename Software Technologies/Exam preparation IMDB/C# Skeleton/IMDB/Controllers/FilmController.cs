using System.Linq;
using System.Net;
using System.Web.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    [ValidateInput(false)]
    public class FilmController : Controller
    {
       

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var database = new IMDBDbContext())
            {
                var films = database.Films.ToList();
                return View(films);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            if (ModelState.IsValid)
            {
                using (var database = new IMDBDbContext())
                {
                    database.Films.Add(film);
                    database.SaveChanges();
                    return Redirect("/");
                }
            }

            return View();
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            using (var database = new IMDBDbContext())
            {
                var film = database.Films.Find(id);

                if (film == null)
                {
                    return HttpNotFound();
                }

                return View(film);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Film filmModel)
        {
            using (var database = new IMDBDbContext())
            {
                var film = database.Films.Find(filmModel.Id);

                if (ModelState.IsValid)
                {
                    film.Name = filmModel.Name;
                    film.Genre = filmModel.Genre;
                    film.Director = filmModel.Director;
                    film.Year = filmModel.Year;

                    database.SaveChanges();

                    return Redirect("/");
                }

                return View("Edit", filmModel);
            }  
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            using (var database = new IMDBDbContext())
            {
                var film = database.Films.Find(id);

                if (film == null)
                {
                    return HttpNotFound();
                }

                return View(film);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Film filmModel)
        {
            using (var database = new IMDBDbContext())
            {
                var film = database.Films.Find(id);

                if (film == null)
                {
                    return HttpNotFound();
                }

                database.Films.Remove(film);
                database.SaveChanges();

                return Redirect("/");
            }
        }
    }
}