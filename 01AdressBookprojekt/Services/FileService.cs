

namespace _01AdressBookprojekt.Services
{
    internal class FileService
    {
        private readonly static string filePath = @"C:\Users\Lenovo\Desktop\contacts.json";

        public static void SaveToFile(string contentAsJson) 
        
        {
            using var sw = new StreamWriter(filePath);
            sw.Write(contentAsJson);
            

        
        
        }

        public static string ReadFromFile()
        {
            if (File.Exists(filePath))
            {
                using StreamReader sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }
            return null!;
        }

    }
}
