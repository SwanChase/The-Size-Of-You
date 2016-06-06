using UnityEngine;
using System.Collections;

public class Resizer : MonoBehaviour
{
    //class for the the recieving of the grow or Shrink Delegates and Changing them acordingly

    private Resizing grow;
    private Resizing shrink;

    void Awake()
    {
        Resizing.Grower += Growing;
        Resizing.Shrinker += Shrinking;
        //grow = GameObject.FindGameObjectWithTag(Tags.GROWWALL).GetComponent<Resizing>();
        //grow.Grower += Growing;
        //shrink = GameObject.FindGameObjectWithTag(Tags.SHRINKWALL).GetComponent<Resizing>();
        //shrink.Shrinker += Shrinking;
    }

    void Shrinking(float shrinkValue)
    {
        print("how much is it shrinking?: " + shrinkValue);
        gameObject.transform.localScale -= new Vector3(shrinkValue, shrinkValue);
    }

    void Growing(float growValue)
    {
        print("how much is it growing?: " + growValue);
        gameObject.transform.localScale += new Vector3(growValue, growValue);
    }
}
//---------------------------------------------------------\\
/*public class ExampleClass : MonoBehaviour
{
    public GameObject respawnPrefab;
    public GameObject[] respawns;
    void Start()
    {
        if (respawns == null)
            respawns = GameObject.FindGameObjectsWithTag("Respawn");

        foreach (GameObject respawn in respawns)
        {
            Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);
        }
    }
}
RotateArea[] ras;
     
     void Start () 
     {
         _cruncher = GetComponentInChildren<CrunchPlatformColliders>();
         GameObject player = GameObject.FindGameObjectWithTag("Player");
         _disablePlayer = player.GetComponentInChildren<DisablePlayer>();
     
         GameObject[] gos = GameObject.FindGameObjectsWithTag("rotateZone");
         ras = new RotateArea[gos.Length];
         for(int i = 0; i < gos.Length; i++) {
             ras[i] = gos[i].GetComponent<RotateArea>();
         }
     }
bool CanRotate() {
         foreach (RotateArea ra in ras) {
             if (ra.isInRotateZone)
                 return true;
         }
         return false;
     }\

void Start(){
         EventManager.EventContainerOne += NormalFunctionOne;
         EventManager.EventContainerTwo += NormalFunctionTwo;
         EventManager.EventContainerTwo += NormalFunctionThree;
     }
     void NormalFunctionOne(){
         Debug.Log("Func 1");
     }
     void NormalFunctionTwo(){
         Debug.Log("Func 2");
     }
     void NormalFunctionThree(){
         Debug.Log("Func 3");
     }
*/
