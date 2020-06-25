using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersLib.TagHelpers.Subject
{
    [HtmlTargetElement("subject-card")]
    public class SubjectCardTagHelper : TagHelper
    {
        public AuthoringTagHelpers.Data.Subject Subject { get; set; }
        private string  SourceLink = $"https://export.arxiv.org/list/#SubjectCode#/recent";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            SourceLink = SourceLink.Replace("#SubjectCode#", Subject.Code);
            string content = $@"
                            <div class='card' style='width:320px;height:150px'>                                
                                <div class='card-body'>
                                    <h6 class ='card-title' style='font-size:16px;font-weight:600;'>{Subject.Name}</h6>
                                        <p class='card-subtitle mb-2 text-muted'>{Subject.GroupName}</p>
                                          <div class ='card-text' style='font-size:10px;'>
                                        <a href='{SourceLink.Replace("#SubjectCode#", Subject.Code)}' class='card-link' style='font-size:10px;' target='_blank'>{Subject.Code}</a>
                                    </div>
                                </div>
                               <div class='card-footer' style='font-size:10px;'>{Subject.Discipline.ToUpper()}</div>
                            </div>
            ";

            output.TagName = "div";
            output.Content.SetHtmlContent(content);
            //< div class='card-img'><img src = 'static/icons/cond-mat.mes-hall_nanotechnology.svg' ></ div >
        }
    }
}
