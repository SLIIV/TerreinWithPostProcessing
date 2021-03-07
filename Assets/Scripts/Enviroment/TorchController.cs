using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour
{
    public GameObject OffState;
    public GameObject OnState;
    
    public void ActivateTorch(bool state)
    {
        OffState.SetActive(!state);
        OnState.SetActive(state);
    }
}
