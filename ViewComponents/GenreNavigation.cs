using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicsStore.Models;
namespace BooksStore.ViewComponents
{
    public class GenreNavigation : ViewComponent
    {
        private IComicsStoreRepository repository;
        public GenreNavigation(IComicsStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData?.Values["genre"];
            return View(repository.Comics
            .Select(x => x.Genre)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}