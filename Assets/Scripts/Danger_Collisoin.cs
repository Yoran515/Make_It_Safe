using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger_Collisoin : MonoBehaviour
{
    TimeVideo TIMEVALUE;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "DangerBlocks")
       {
            Debug.Log("YOU WON");
       }
    }
}