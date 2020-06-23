using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AuthoringTagHelpers.Data
{
    public class DataReader : IDataReader
    {
        private readonly string articlesPath = @"AuthoringTagHelpers.Data.Articles.json";
        private readonly string subjectsPath = @"AuthoringTagHelpers.Data.Subjects.json";

        public List<Article> ReadArticles()
        {
            var result = ReadDocument(articlesPath);
            var articles = JsonConvert.DeserializeObject<List<Article>>(result);
            return articles;
        }

        public List<Subject> ReadSubjects()
        {
            var result = ReadDocument(subjectsPath);
            var subjects =  JsonConvert.DeserializeObject<List<Subject>>(result);
            return subjects;
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

