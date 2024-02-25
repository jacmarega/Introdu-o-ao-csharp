using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EditorTXT
{
    public static class Gerenciador
    {
        //Valores padrões
        public static string DefaultFolderPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        public static string DefaultFileName => "Arquivo";
        public static string DefaultFileExt = ".txt";

        //Valores atribuidos ao uso
        public static string Folderpath { get; set; } = DefaultFolderPath;
        public static string FileName { get; set; } = DefaultFileName;
        public static string FileExt { get; set; } = DefaultFileExt;
        public static string FilePath => Folderpath + FileName + FileExt;
    }
}
