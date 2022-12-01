using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainProject;

public static class Check
{
    public static void Likes(string[] name)
    {
        if (name is null)
        {
            Console.WriteLine();
            Console.WriteLine("Никто не оценил");
            Console.WriteLine();
            return;
        }
        else if (name.Length == 1)
        {
            Console.WriteLine();
            Console.WriteLine($"{name[0]} оценил запись");
            Console.WriteLine();
            return;
        }
        else if (name.Length == 2)
        {
            Console.WriteLine();
            Console.WriteLine($"{name[0]} and {name[1]} оценили запись");
            Console.WriteLine();
            return;
        }
        else if (name.Length == 3)
        {
            Console.WriteLine();
            Console.WriteLine($"{name[0]}, {name[1]} and {name[2]} оценили запись");
            Console.WriteLine();
            return;
        }
        else if (name.Length >= 4)
        {
            Console.WriteLine();
            Console.WriteLine($"{name[0]}, {name[1]} and {name.Length - 2} others оценили запись");
            Console.WriteLine();
            return;
        }
    }
}
