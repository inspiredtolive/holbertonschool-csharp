using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Provides obj type-related methods.
/// </summary>
class Obj
{
    /// <summary>
    /// Prints properties and methods of an obj.
    /// </summary>
    /// <param name="myObj">The obj to print properies and methods of.</param>
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();
        PropertyInfo[] props = objType.GetProperties();
        MethodInfo[] methods = objType.GetMethods();

        Console.WriteLine("{0} Properties:", objType.Name);
        foreach (PropertyInfo prop in props)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine("{0} Methods:", objType.Name);
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
