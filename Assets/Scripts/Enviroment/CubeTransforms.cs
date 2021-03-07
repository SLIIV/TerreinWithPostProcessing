using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransforms : MonoBehaviour
{

    public void ChangeScale(float scaleMultiply)
    {
        Vector3 currentScale = gameObject.transform.localScale;
        gameObject.transform.localScale *= scaleMultiply;
    }

    public void AddForceUp(float force)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force);       
    }

    public void DestroyObject(float timeToDestroy)
    {
        Destroy(gameObject, timeToDestroy);
    }
}
