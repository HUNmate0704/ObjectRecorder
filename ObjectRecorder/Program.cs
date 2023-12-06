using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectRecorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = RecordObject<Person>();
            ;
        }

        static T RecordObject<T>()
        {
            Type t = typeof(T);
            object instance = Activator.CreateInstance(t);
            foreach (var item in t.GetProperties())
            {
                Console.WriteLine($"Enter {item.Name} value:");
                string result = Console.ReadLine();

                if (item.PropertyType == typeof(string))
                {
                    item.SetValue(instance, result);
                }
                else
                {
                    Type propType = item.PropertyType;
                    var ParseMethod = propType.GetMethods().First(t => t.Name.Contains("Parse"));
                    var converted = ParseMethod.Invoke(null, new object[] { result });
                    item.SetValue(instance, converted);

                }




            }
            return (T)instance;
        }

        static void CollectionTraverser<T>(IEnumerable<T> collection)
        {
            Type t = typeof(T);
            foreach (var item in t.GetProperties())
            {
                Console.Write(item.Name.Length > 7 ? item.Name.Substring(0, 7) : item.Name + "\t");

            }
            Console.WriteLine();
            foreach (var item in collection)
            {
                foreach (var prop in t.GetProperties())
                {
                    if (prop.GetValue(item).ToString().Length > 7)
                    {
                        Console.Write(prop.GetValue(item).ToString().Substring(0, 7) + "\t");
                    }
                    else
                    {
                        Console.Write(prop.GetValue(item) + "\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
