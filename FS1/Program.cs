using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FS1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"C:\Users\плотниковс\Documents\visual studio 2015\Projects\FS1\FS1\text.txt";
            FileStream fs = new FileStream(url, FileMode.Create);
            FileStream fs2 = new FileStream(url, FileMode.Create, FileAccess.Write);
            FileStream fs3 = new FileStream(url, FileMode.Create, FileAccess.Write, FileShare.None);
        }
    }
}
