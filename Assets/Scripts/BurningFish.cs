using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningFish : AnimatedFish
{
    float burning_seconds;
    Timer burn_timer;
    GameObject animate;
    bool isDestroyed = false;
    BoxCollider2D this_collider;
    SpriteRenderer this_sprite;

    void Start()
    {
        point_value = 2;
        burning_seconds = 2;
        burn_timer = gameObject.AddComponent<Timer>();
        this_collider = GetComponent<BoxCollider2D>();
        this_sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isDestroyed)
        {
            if (burn_timer.TimerFinished())
            {
                Destroy(animate);
                Destroy(gameObject);
            }

            if (burn_timer.isRunning) burn_timer.TimerUpdate();
        }
    }

    public override void destroy_fish()
    {
        isDestroyed = true;

        burn_timer.SetTimer(burning_seconds);

        total += point_value;

        Vector2 location = transform.position;
        animate = Instantiate<GameObject>(PrefabAnimation);
        animate.transform.position = location;
        Destroy(this_collider);
        Destroy(this_sprite);

        Debug.Log("+" + point_value + " points");
        Debug.Log("Total Points: " + total);
    }
}
