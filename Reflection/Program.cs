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
            PropertyInfo[] properties = typeof(Student).GetProperties();

            void DisplayPublicProperties()
            {               
                foreach (PropertyInfo p in properties)
                {
                    Console.WriteLine(p.Name);                   
                }
            }

            void CreateInstance()
            {
                Student instance = new Student();               

                foreach (PropertyInfo p in properties)
                {
                    var type = p.PropertyType;

                    Console.Write($"\nInforme o valor da propriedade {p.Name}: ");

                    if(type == typeof(int))
                    {
                        p.SetValue(instance, int.Parse(Console.ReadLine()));
                    }
                    else
                    {
                        p.SetValue(instance, Console.ReadLine());
                    }

                }
                instance.DisplayInfo();
            }

            DisplayPublicProperties();
            CreateInstance();
        }
    }
}
