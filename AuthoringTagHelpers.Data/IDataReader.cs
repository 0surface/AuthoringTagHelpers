using System.Collections.Generic;

namespace AuthoringTagHelpers.Data
{
    public interface IDataReader
    {
        List<Article> ReadArticles();
    }
}
