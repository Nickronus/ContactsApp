using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ContactsApp.Model
{
    /// <summary>
    /// Класс управления данными проекта.
    /// </summary>
    internal class ProjectManager
    {
        /// <summary>
        /// Путь сохранения контактов.
        /// </summary>
        private const string _filePath = "C:\\Users\\Nickr\\AppData\\Roaming\\<ваше имя>\\ContactsApp\\ContactsApp.notes";

        /// <summary>
        /// Возвращает путь файла.
        /// </summary>

        public string FilePath
        {
            get { return _filePath; }
        }

        /// <summary>
        /// Записывает контакты в файл.
        /// </summary>
        public void WriteProjectToJsonFile(Project project)
        {
            string json = JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        /// <summary>
        /// Загружает контакты из файла.
        /// </summary>
        public Project LoadProjectFromJsonFile()
        {
            return JsonConvert.DeserializeObject<Project>(FilePath);
        }
    }
}
