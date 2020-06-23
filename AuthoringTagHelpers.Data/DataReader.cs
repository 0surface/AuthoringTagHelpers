using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AuthoringTagHelpers.Data
{
    public class DataReader : IDataReader
    {
        private readonly string articlesPath = @"tagHelper.Basic.MVC.Data.Articles.json";



        public List<Article> ReadArticles()
        {
            var result = ReadDocument(articlesPath);
            var articles = JsonConvert.DeserializeObject<List<Article>>(result);
            return articles;
        }

        private string ReadDocument(string resourceName)
        {
            string testData = "";
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                testData = reader.ReadToEnd();
            }

            return testData;
        }

    }
}
