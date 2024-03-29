using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingFish : AnimatedFish
{
    void Start()
    {
        point_value = 3;
    }

    public override void destroy_fish()
    {
        total += point_value;
        Vector2 location = transform.position;
        GameObject animate = Instantiate<GameObject>(PrefabAnimation);
        animate.transform.position = location;
        Destroy(gameObject);

        Debug.Log("+" + point_value + " points");
        Debug.Log("Total Points: " + total);
    }
}
