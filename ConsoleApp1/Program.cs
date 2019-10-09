using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string path = "D://текст.txt";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string text = sr.ReadToEnd();

                string[] predl = text.Split(new Char[] { '.' });
                for (int i = predl.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(predl[i]);

                }
            }
            else
            {
                Console.WriteLine("Произошла ошибка");
            }
            Console.Read();

        }
    }
}
