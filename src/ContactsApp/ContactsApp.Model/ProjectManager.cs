namespace ContactsApp.Model
{
    using Newtonsoft.Json;
    using System.IO;
    using System;

    /// <summary>
    /// Класс управления данными проекта.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Путь к системной папке с данными приложений.
        /// </summary>
        private static string _appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// Имя файла.
        /// </summary>
        private static string _fileName = "ContactsApp.notes";

        /// <summary>
        /// Путь к папке сохранения.
        /// </summary>
        private static string _path = $@"{_appData}\ContactsApp";

        /// <summary>
        /// Возвращает путь файла.
        /// </summary>
        public string Path
        {
            get { return _path; }
        }

        /// <summary>
        /// Возвращает имя файла.
        /// </summary>
        public string FileName
        {
            get { return _fileName; }
        }

        /// <summary>
        /// Записывает контакты в файл с проверкой существования папки.
        /// </summary>
        public void WriteProjectToJsonFile(Project project)
        {
            if(! Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            string json = JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText(Path + FileName, json);
        }

        /// <summary>
        /// Загружает контакты из файла.
        /// </summary>
        public Project LoadProjectFromJsonFile()
        {
            try
            {
                return JsonConvert.DeserializeObject<Project>(Path + FileName);
            }
            catch(Exception)
            {
                return new Project();
            }
        }
    }
}
