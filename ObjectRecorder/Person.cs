using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRecorder
{
    internal class Person/* : /*IComparable<Person>*/
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        //public bool IsMan { get; set; }
        public Person()
        {

        }
        public Person(string name, int age, string job)
        {
            Name = name;
            Age = age;
            Job = job;
        }

        //public void ChangeIsMan()
        //{
        //    IsMan = !IsMan;
        //}

        //public int Highest<T>()
        //{
        //    if (Name.Length > Age)
        //    {
        //        return Name.Length;
        //    }
        //    else
        //    {
        //        return Age;
        //    }
        //}

        //public int CompareTo(Person other)
        //{
        //    if (Age > other.Age)
        //    {
        //        return 1;
        //    }
        //    else if (Age < other.Age)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        if (IsMan)
        //        {
        //            return -1;
        //        }
        //        else if (other.IsMan)
        //        {
        //            return 1;
        //        }
        //        return 0;
        //    }
        //}
    }
}
