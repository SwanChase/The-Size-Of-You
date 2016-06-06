using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour
{
    //make the wall scream out its being touched and make the player listen using Delegates
    //and in the player make a function for resizing the player


    public delegate void Grower(int sizeValue);
    public Grower growing;

    void OnTriggerStay2D(Collider2D coll)
    {
        //checks if the hit colider is the Lever
        if (coll.gameObject.tag == Tags.PLAYER)
        {
            if (growing != null)
            {
                growing(5);
            }
        }
    }
}
