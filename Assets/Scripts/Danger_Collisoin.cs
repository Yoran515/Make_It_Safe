using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Danger_Collisoin : MonoBehaviour
{
    public InputActionReference gripInputActionReference;
     void OnTriggerStay(Collider other)
     {
        Debug.Log("HITTEST");
        if (other.CompareTag("Handlines"))
        {
        
            Debug.Log("HIT");
        }
     }
  
}
