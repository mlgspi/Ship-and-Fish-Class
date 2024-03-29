using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    Rigidbody2D myRigidBody2D;
    FishCollector myCollector;
    GameObject target;

    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        myCollector = Camera.main.GetComponent<FishCollector>();
    }

    void OnMouseDown()
    {
        if (myCollector.FishList.Count != 0)
        {
            target = myCollector.FishList[0];
            Vector2 direction = new Vector2(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y);
            myRigidBody2D.AddForce(direction, ForceMode2D.Impulse);
        }

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == target)
        {
            myCollector.FishList.Remove(target);
            target.GetComponent<Fish>().destroy_fish();
            myRigidBody2D.velocity = new Vector2(0, 0);
            OnMouseDown();
        }
    }
}