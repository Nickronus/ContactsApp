using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ContactsApp.Model
{
    internal class ProjectManager
    {
        private const string _filePath = "C:\\Users\\Nickr\\AppData\\Roaming\\<ваше имя>\\ContactsApp\\ContactsApp.notes";

        public void WriteProjectToJsonFile(Project project)
        {
            string json = JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public Project LoadProjectFromJsonFile()
        {
            return JsonConvert.DeserializeObject<Project>(_filePath);
        }
    }
}
