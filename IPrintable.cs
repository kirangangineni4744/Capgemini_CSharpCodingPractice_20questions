using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    interface IPrintable
    {
        void Print();
    }

    interface ISerializable
    {
        void SaveToFile();
    }

    class Report : IPrintable, ISerializable
    {
        private string content;

        public Report(string content)
        {
            this.content = content;
        }

        public void Print()
        {
            Console.WriteLine($"Printing Report: {content}");
        }

        public void SaveToFile()
        {
            File.WriteAllText("report.txt", content);
            Console.WriteLine("Report saved to file.");
        }
    }
}
