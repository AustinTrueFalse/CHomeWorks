
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Concurrent;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;



class Program
{

    static void Main(string[] args)
    {
        var classes = new[]
        {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };


        var allStudents = GetAllStudents(classes);


        Console.WriteLine(string.Join(" ", allStudents));


        //foreach (var classroom in classes)
        //{
        //    foreach (var student in classroom.Students)
        //    {
        //        Console.WriteLine(student);
        //    }
        //}
    }




    static string[] GetAllStudents(Classroom[] classes)
    {
        var result = new List<string>();

        foreach (var classroom in classes)
        {
            foreach (var student in classroom.Students)
            {
                result.Add(student);
            }
        }

        return result.ToArray();

    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }


}


