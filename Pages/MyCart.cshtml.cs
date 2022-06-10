using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ComicsStore.MyTagHelper;
using ComicsStore.Models;
using System.Linq;
namespace ComicsStore.Pages
{
    public class MyCartModel : PageModel
    {
        private IComicsStoreRepository repository;
        public MyCartModel(IComicsStoreRepository repo, MyCart myCartService)
        {
            repository = repo;
            myCart = myCartService;
        }
        public MyCart myCart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long comicId, string returnUrl)
        {
            Comic comic = repository.Comics
            .FirstOrDefault(b => b.ComicID == comicId);
            myCart.AddItem(comic, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long comicId, string returnUrl)
        {
            myCart.RemoveLine(myCart.Lines.First(cl =>
            cl.Comic.ComicID == comicId).Comic);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}