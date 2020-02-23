using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreRandom
{
    public static int Pick(params int[] numbers)
    {
        return numbers[(Random.Range(0, numbers.Length))];
    }

    public static float Pick(params float[] numbers)
    {
        return numbers[(Random.Range(0, numbers.Length))];
    }
}
