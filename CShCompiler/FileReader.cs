using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CShCompiler
{
    class FileReader
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;

        public string Reader()
        {
            string result;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|text files(*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                    
                    try
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();                            
                        }
                        result = "Загружено";
                    }
                    catch (Exception e)
                    {
                        result = e.Message;
                    }           

                }
                else
                {
                    result = "Файл не указан";
                }
            }
            return result;
        }
    }
}
