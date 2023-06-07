using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MiscUtils
{
    public static void ForEach<T>(this T[] arr, Action<T> action) 
    { 
        foreach(var item in arr) 
            action(item); 
    }
}
