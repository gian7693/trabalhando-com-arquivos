using System;
using System.IO;
using System.Collections.Generic;
using Course.Entities;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aula de File e FileInfo
            #region File_FileInfo

            string sourcePath = @"c:\Temp\file1.txt";
            string targetPath = @"c:\Temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }

            #endregion

            // Aula de FileStream e StreamReader
            #region FileStream_StreamReader

            //string path = @"c:\Temp\file1.txt";
            //FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{           
            //    sr = File.OpenText(path);

            //    while(!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }

            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if(sr != null) sr.Close();
            //}

            #endregion

            // Aula do Bloco using
            #region Bloco_Using

            //string path = @"c:\Temp\file1.txt";

            //// Ao final da execução o recurso será automaticamente fechado
            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            // Aula de StreamWriter
            #region StreamWriter

            //string sourcePath = @"c:\Temp\file1.txt";
            //string targetPath = @"c:\Temp\file2.txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);

            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach(string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }

            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            // Aula de Directory e DirectoryInfo
            #region Directory_DirectoryInfo

            //string path = @"c:\Temp\myfolder";

            //try
            //{
            //    // Apresentar todas as subpastas contidas dentro do caminho
            //    IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("Folders:");

            //    foreach (string folder in folders)
            //    {
            //        Console.WriteLine(folder);
            //    }

            //    Console.WriteLine();

            //    // Apresentar todas os arquivos contidas dentro do caminho
            //    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("Files:");

            //    foreach (string file in files)
            //    {
            //        Console.WriteLine(file);
            //    }

            //    // Criar uma pasta
            //    Directory.CreateDirectory(path + @"\newfolder");

            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            // Aula de Path
            #region Path

            //string path = @"c:\Temp\myfolder\file1.txt";

            //Console.WriteLine(Path.GetFileName(path));
            //Console.WriteLine(Path.GetDirectoryName(path));

            #endregion

            #region Exercicio_Proposto

            //try
            //{
            //    Console.WriteLine("Insert the full path of the file");
            //    string sourceFilePath = Console.ReadLine();

            //    string[] lines = File.ReadAllLines(sourceFilePath);

            //    string sourceDirectoryPath = Path.GetDirectoryName(sourceFilePath);
            //    string targetDirectoryPath = sourceDirectoryPath + @"\out";
            //    string targetFilePath = targetDirectoryPath + @"\summary.csv";

            //    Directory.CreateDirectory(targetDirectoryPath);

            //    using (StreamWriter sw = File.AppendText(targetFilePath))
            //    {                    
            //        foreach (string line in lines) 
            //        {
            //            string[] columns = line.Split(";");

            //            Product prod = new Product(columns[0], double.Parse(columns[1], CultureInfo.InvariantCulture), int.Parse(columns[2]));
            //            sw.WriteLine(prod.Name + ";" + prod.Total().ToString("F2", CultureInfo.InvariantCulture));   
            //        }
            //    }


            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}

            #endregion
        }
    }
}
