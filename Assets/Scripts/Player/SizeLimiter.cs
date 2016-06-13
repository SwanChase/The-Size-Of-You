using UnityEngine;
using System.Collections;

public class SizeLimiter : MonoBehaviour
{

    [SerializeField]
    float minSize;
    [SerializeField]
    float maxSize;

    void Update()
    {
        transform.localScale = new Vector3(
              Mathf.Clamp(transform.localScale.x, minSize, maxSize),
              Mathf.Clamp(transform.localScale.y, minSize, maxSize),
              Mathf.Clamp(transform.localScale.z, minSize, maxSize));

    }
}
