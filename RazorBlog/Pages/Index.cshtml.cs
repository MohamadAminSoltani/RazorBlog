﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Models;
using System.Collections.Generic;
using System.Linq;

namespace RazorBlog.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }
        private readonly BlogContext _context;
        public IndexModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Articles = _context.Articles.Select(x => new ArticleViewModel 
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
            }).OrderByDescending(x=>x.Id).ToList();
        }
    }
}
