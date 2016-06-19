using UnityEngine;
using System.Collections;

public class Resizer : MonoBehaviour//name for script needs to be changed
{
    //class for the the recieving of the grow or Shrink Delegates and Changing them acordingly
    bool canShrink = true;
    bool canGrow = true;
    bool canResize = false;

    [SerializeField]
    float resizeCooldown;
    [SerializeField]
    float preCooldownPause = 0.01f;

    Resizing grow;
    Resizing shrink;

    //---------sound
    [SerializeField]
    string shrinkSFXName;
    [SerializeField]
    string growSFXName;

    SoundController soundController;

    void Start()
    {
        soundController = SoundController.instance;
        if (soundController == null)
        {
            Debug.LogError("There aint no SoundController here man");
        }
    }

    void Awake()
    {
        Resizing.Grower += Growing;
        Resizing.Shrinker += Shrinking;
    }

    void Shrinking(float shrinkValue)
    {
        StartCoroutine(ShrinkCoroutine());
        if (canShrink)
        {
            gameObject.transform.localScale -= new Vector3(shrinkValue, shrinkValue);
            soundController.PlaySound("ShrinkSFX");
        }
    }

    void Growing(float growValue)
    {
        StartCoroutine(GrowCoroutine());
        if (canGrow)
        {
            gameObject.transform.localScale += new Vector3(growValue, growValue);
            soundController.PlaySound(growSFXName);
        }
    }

    IEnumerator ShrinkCoroutine()
    {
        yield return new WaitForSeconds(preCooldownPause);
        canShrink = false;
        yield return new WaitForSeconds(resizeCooldown);
        canShrink = true;
    }

    IEnumerator GrowCoroutine()
    {
        yield return new WaitForSeconds(preCooldownPause);
        canGrow = false;
        yield return new WaitForSeconds(resizeCooldown);
        canGrow = true;
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
