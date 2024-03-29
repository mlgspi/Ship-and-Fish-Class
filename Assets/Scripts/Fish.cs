using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fish : MonoBehaviour
{
    public int point_value;
    abstract public void destroy_fish();
    public static int total = 0;

    public int Total { get { return total; } }
}