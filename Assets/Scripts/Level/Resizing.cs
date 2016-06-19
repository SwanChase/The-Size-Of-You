using UnityEngine;
using System.Collections;

public class Resizing : MonoBehaviour//name for script needs to be changed
{
    //make the wall say its being touched and make the player listen using Delegates
    //and in the player make a function for resizing the player
    [SerializeField]
    float resizingValue;

    [SerializeField]
    bool isGrower = false;
    [SerializeField]
    bool isShrinker = false;

    public delegate void Resizer(float sizeValue);
    public static event Resizer Grower;
    public static event Resizer Shrinker;



    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == Tags.PLAYER)
        {
            if (isGrower)
            {
                Grower(resizingValue);
            }

            if (isShrinker)
            {
                Shrinker(resizingValue);
            }
        }
    }
}
