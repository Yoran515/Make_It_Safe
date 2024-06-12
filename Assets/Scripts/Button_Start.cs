using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Start : MonoBehaviour
{
    public Controllers_VR controller;
    void Start()
    {
        controller = GetComponent<Controllers_VR>();
    }
    public void Update()
    {
        
    }
    public void Click()
    {
        float leftTriggerValue = controller.GetLeftTriggerValue();

        if (leftTriggerValue != 1)
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("GOO");
        }
    }
}
   
