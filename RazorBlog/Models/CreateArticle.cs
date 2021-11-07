using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorBlog.Models
{
    public class CreateArticle
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage ="عنوان مقاله اجباری است")]
        public string Title { get; set; }

        [DisplayName("مسیر تصویر")]
        [Required(ErrorMessage = "تصویر مقاله اجباری است")]
        public string Picture { get; set; }

        [DisplayName("Alt تصویر")]
        public string PictureAlt { get; set; }

        [DisplayName("عنوان تصویر")]
        public string PictureTitle { get; set; }

        [DisplayName("توضیحات کوتاه")]
        [Required(ErrorMessage = "توضیحات کوتاه مقاله اجباری است")]
        public string ShortDescription { get; set; }

        [DisplayName("متن مقاله")]
        public string Body { get; set; }
    }
}
