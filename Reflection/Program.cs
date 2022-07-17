using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            void DisplayPublicProperties()
            {
                PropertyInfo[] properties = typeof(Student).GetProperties();

                foreach (PropertyInfo p in properties)
                {
                    Console.WriteLine(p.Name);                   
                }
            }
            DisplayPublicProperties();
        }
    }
}
