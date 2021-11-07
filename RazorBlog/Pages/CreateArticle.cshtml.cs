using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Models;

namespace RazorBlog.Pages
{
    public class CreateArticleModel : PageModel
    {
        private readonly BlogContext _context;
        public CreateArticle Command { get; set; }

        [TempData]
        public string SuccessMessage { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public CreateArticleModel(BlogContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(CreateArticle command)
        {
            if (ModelState.IsValid)
            {
                var article = new Article(command.Title, command.Picture, command.PictureAlt, command.PictureTitle, command.ShortDescription, command.Body);

                _context.Articles.Add(article);
                _context.SaveChanges();

                //TempData["Success"] = "مقاله با موفقیت ذخیره شد";
                SuccessMessage = "مقاله با موفقیت ذخیره شد";

                return RedirectToPage("./Index");            }
            else
            {
                //TempData["Error"] = "لطفا مقادیر خواسته شده را تکمیل نمایید";
                ErrorMessage = "لطفا مقادیر خواسته شده را تکمیل نمایید";

                return Page();
            }

        }
    }
}
