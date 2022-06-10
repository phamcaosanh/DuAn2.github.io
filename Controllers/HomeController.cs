using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ComicsStore.Models;
using ComicsStore.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.IO;
using System;

namespace ComicsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ComicsStoreDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        private IComicsStoreRepository repository;
        public int PageSize = 4;
        public HomeController(IComicsStoreRepository repo, ComicsStoreDbContext context, IWebHostEnvironment hostEnvironment)
        {
            repository = repo;
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index(string genre, int ComicPage = 1)
        => View(new ComicsListViewModel
        {
            Comics = repository.Comics
            .Where(p => genre == null || p.Genre == genre)
            .OrderBy(p => p.ComicID)
            .Skip((ComicPage - 1) * PageSize)
            .Take(PageSize),
        PagingInfo = new PagingInfo
        {
            CurrentPage = ComicPage,
            ItemsPerPage = PageSize,
            TotalItems = genre == null ?
            repository.Comics.Count() :
            repository.Comics.Where(e =>
            e.Genre == genre).Count()
        },
            CurrentGenre = genre
        });

        public IActionResult Admin(string genre, int ComicPage = 1)
        => View(new ComicsListViewModel
        {
            Comics = repository.Comics
            .Where(p => genre == null || p.Genre == genre)
            .OrderBy(p => p.ComicID)
            .Skip((ComicPage - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = ComicPage,
                ItemsPerPage = PageSize,
                TotalItems = genre == null ?
            repository.Comics.Count() :
            repository.Comics.Where(e =>
            e.Genre == genre).Count()
            },
            CurrentGenre = genre
        });

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ComicViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                Comic comic = new Comic
                {

                    Title = model.Title,
                    Description = model.Description,
                    Release = model.Release,
                    Genre = model.Genre,
                    Price = model.Price,
                    ProfilePicture = uniqueFileName,
                };
                dbContext.Add(comic);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private string UploadedFile(ComicViewModel model)
        {
            string uniqueFileName = null;

            if (model.ImageComic != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageComic.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageComic.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}