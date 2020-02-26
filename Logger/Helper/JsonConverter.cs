
using System.IO;
using Newtonsoft.Json;

namespace Logger.Helper
{
    public class JsonConverter : IJsonConverter
    {
        private readonly string _filePath;

        public JsonConverter(string filePath)
        {
            _filePath = filePath;
        }

        public T Deserialize<T>() where T : class
        {
            var fileContent = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<T>(fileContent);
        }
    }
}
