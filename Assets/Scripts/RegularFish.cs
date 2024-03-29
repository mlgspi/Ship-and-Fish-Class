using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularFish : Fish
{
    private void Start()
    {
        point_value = 1;
    }

    public override void destroy_fish()
    {
        total += point_value;
        Destroy(gameObject);

        Debug.Log("+" + point_value + " points");
        Debug.Log("Total Points: " + total);
    }
}
