using System.Collections.Generic;

namespace AuthoringTagHelpers.Data
{
    public class Article
    {
        public string PageHeaderInfo { get; set; }
        public string DateContextInfo { get; set; }
        public string H3HeaderText { get; set; }

        public string ArxivIdLabel { get; set; }
        public string ArxivId { get; set; }
        public string AbstractUrl { get; set; }
        public string PdfUrl { get; set; }
        public string OtherFormatUrl { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public string AbstractText { get; set; }
        public string[] PrimarySubject { get; set; }
        public List<SubjectItemDto> SubjectItems { get; set; } = new List<SubjectItemDto>();
        public List<AuthorDto> Authors { get; set; } = new List<AuthorDto>();
    }
    public class SubjectItemDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class AuthorDto
    {
        public string Code { get; set; }
        public string FullName { get; set; }
        public string ContextUrl { get; set; }
    }
}
