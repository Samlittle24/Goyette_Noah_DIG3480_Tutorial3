using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    private void OnTriggerExit(Collider other) 
    {
        Destroy(other.gameObject);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
