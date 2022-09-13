using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6_Value_Reference_Types_Exercise_01;
internal class Methods
{

    public static void ChangeValueType(double x)
    {
        x = 1.125; // x's value has been changed to 1.125
    }

    public static void ChangeValueType(int x)
    {
        x = 100; // x's value has been changed to 100
    }

    public static void ChangeValueType(string x)
    {
        x = "A new value"; // x's value has been chaged to "A new value"
    }


    public static void ChangeReferenceType(StringBuilder sb)
    {
        sb.Remove(0, sb.Length);
        sb.Append("The ending string's value.");
    }

    public static void ChangeReferenceType(List<int> list)
    {
        list.RemoveAll(x => x < 4);
        list.Add(100);
        list.Add(200);
        list.Add(300);
    }

    public static void ChangeReferenceType(int[] arr)
    {
        arr[0] = 400;
        arr[1] = 500;
        arr[2] = 600;
    }

    public static void ChangeReferenceType(Dog dog)
    {
        dog.name = "A changed name";
    }


    public static void AddSpaces(int numberOfSpaces)
    {
        while (numberOfSpaces > 0)
        {
            Console.WriteLine();
            numberOfSpaces++;
        }
    }
}
