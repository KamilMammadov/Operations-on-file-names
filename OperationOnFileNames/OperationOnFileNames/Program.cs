using System;

namespace OperationOnFileNames
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagement firstfile = new FileManagement(".jpg", ".png", ".docx", ".txt", ".index", ".html", ".pdf",".css");

            
            Console.WriteLine(firstfile.IsExtensionExist("kamil.pd"));
     
            Console.WriteLine("------------------------------------------");
            //languages : English, Azerbaijan, Russian (default lannguage : English)

            firstfile.Info("russian");

            Console.WriteLine(firstfile.ReturnExtension("kamil.pd"));
        }
    }

    class FileManagement
    {
        private string[] _extensions;
        public FileManagement(params string[] extensions)
        {
            _extensions = extensions;
        }


        public bool IsExtensionExist(string text)
        {
            for (int i = 0; i < _extensions.Length; i++)
            {
                if (ReturnExtension(text) == _extensions[i])
                {
                    return true;
                }
            }

            return false;

        }


        public void Info()
        {
            Info("English");
        }

        public void Info(string language)
        {
            language = language.ToLower();

            switch (language)
            {
                case "azerbaijan":
                    Console.WriteLine("Desteklenen uzantilar :");
                    break;

                case "russian":
                    Console.WriteLine("Podderjivaemie rasshireniya :");
                    break;
                case "english":
                    Console.WriteLine("Supported Extensions :");
                    break;
                default:
                    Console.WriteLine($" Given {language} language isn't supported");
                    return;
            }

            string comma = ",";
            for (int i = 0; i < _extensions.Length; i++)
            {
                if (i == _extensions.Length - 1)
                {
                    comma = " ";
                }
                Console.Write(_extensions[i] + " " + comma + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
        }

        public string ReturnExtension(string text)
        {
            string targetText = "";
            char dot = '.';

            for (int i = 0; i < text.Length; i++)
            {
                if (dot == text[i])
                {
                    for (int j = i; j < text.Length; j++)
                    {
                        targetText += text[j];
                    }
                }
            }
            return targetText;
        }
    }
}
