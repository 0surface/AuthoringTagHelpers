using AuthoringTagHelpers.Data;
using Microsoft.AspNetCore.Mvc;

namespace AuthoringTagHelpers.Web.ViewComponents
{
    public class ArticleCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Article article)
        {
            string fullPdfUrl = $"https://export.arxiv.org{ article.PdfUrl }";
            article.PdfUrl = fullPdfUrl;
            article.Title = Truncate(article.Title, 90);
            article.AbstractText = Truncate(article.AbstractText, 150);

            return View(article);
        }

        public string Truncate(string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }
    }
}
