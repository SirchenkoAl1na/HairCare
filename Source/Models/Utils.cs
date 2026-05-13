using System;



namespace HairCare.Models;



public static class Utils

{

    public static readonly Random Random = new Random(0);



    public static string RandomFromStrings(params string[] values)

    {

        return values[Random.Next(0, values.Length)];

    }



    public static int RandomInRange(int min, int max)

    {

        return Random.Next(min, max);

    }

    

    public static bool RandomBoolean()

    {

        return Random.Next(0, 2) != 0;;

    }

}