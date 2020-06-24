using Microsoft.AspNetCore.Razor.TagHelpers;
using AuthoringTagHelpers.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace TagHelpersLib.TagHelpers.Subject
{
    [HtmlTargetElement("subject-card")]
    public class SubjectCardTagHelper : TagHelper
    {
        public AuthoringTagHelpers.Data.Subject Subject { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string content = $@"
                            <div class='card' style='max-width:400px;max-height:200px'>                                
                                <div class='card-body'>
                                    <h6 class ='card-title'>{Subject.Name}</h6>
                                    <div class ='card-text'>{Subject.Code}</div>
                                </div>
                            </div>
            ";

            output.TagName = "div";
            output.Content.SetHtmlContent(content);
             //< div class='card-img'><img src = 'static/icons/cond-mat.mes-hall_nanotechnology.svg' ></ div >
        }
    }
}
