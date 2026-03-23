using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using PharmacyApi.Models;

namespace PharmacyApi.Services
{
    public class JsonDataService
    {
        private readonly string _filePath = "data.json";

        public List<Medicine> GetAll()
        {
            if (!File.Exists(_filePath)) return new List<Medicine>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Medicine>>(json) ?? new List<Medicine>();
        }

        public void Save(List<Medicine> medicines)
        {
            var json = JsonSerializer.Serialize(medicines, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(_filePath, json);
        }
    }
}
