using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            //PlayAudiosource
        }
    }
}
