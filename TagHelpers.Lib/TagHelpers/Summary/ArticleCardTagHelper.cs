using AuthoringTagHelpers.Data;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersLib.TagHelpers.Summary
{
    [HtmlTargetElement(ParentTag = "article-track")]
    public class ArticleCardTagHelper : TagHelper
    {
        public Article Article { get; set; }
        private readonly string arxivBaseUrl = @"https://export.arxiv.org";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string pdfUrl = $"{arxivBaseUrl}{Article.PdfUrl}";
            string truncatedTitle = Truncate(Article.Title, 90);
            string truncatedAbstract = Truncate(Article.AbstractText, 150);

            string content = $@"<div class='card' style='max-width:700px;max-height:250px'>                                     
                                    <div class='card-body'>
                                        <div style = 'display: inline;'>
                                            <div class='svg-icon' style = 'display: inline;'> <img src ='static/icons/cond-mat.mes-hall_nanotechnology.svg'></div>                                            
                                            <div style='display: inline;'><h5 class ='card-title'>{truncatedTitle}</h5></div>
                                        </div>
                                        <div class ='card-text'>{truncatedAbstract}</div>
                                        <p class='font-italic'>{Article.Comments}</p>
                                        <a href='{pdfUrl}' class='card-link' >PDF</a>
                                      </div>
                                </div>
                ";

            //output.Attributes.SetAttribute("class", "col-xs-12 col-sm-6 col-md-4 col-lg-3");
            output.TagName = "div";
            output.Content.SetHtmlContent(content);
        }

        public string Truncate(string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }
    }
}
