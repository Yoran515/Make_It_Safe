using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block_Destroyer : MonoBehaviour
{
    public Controllers_VR controller; // Reference to the Controllers_VR script
    public GameObject Cube1;
    public Score score;
    void Start()
    {
        // Find the GameObject with the Controllers_VR script and get its component
        controller = GetComponent<Controllers_VR>();
        

    }
    void Update()
    {
        float leftTriggerValue = controller.GetLeftTriggerValue();
        Debug.Log("TriggerValue=" + leftTriggerValue);
       
    }

    // Update is not needed in this script

    void OnTriggerStay(Collider other)
    {
        // Ensure controller is not null before using it
        float leftTriggerValue = controller.GetLeftTriggerValue();
        if (other.CompareTag("DangerBlocks") && Input.GetKeyDown("space"))
        {
            Cube1.SetActive(false);
           
        }
        // Check if the collided object has the "DangerBlocks" tag
        if (other.CompareTag("DangerBlocks") && leftTriggerValue != 0)
        {
            Cube1.SetActive(false);
            Debug.Log("Test");
            score.ScoreAdd();
            
            score.ShowText();
         
          

        }
    }
}
