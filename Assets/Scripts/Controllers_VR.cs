using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class Controllers_VR : MonoBehaviour
{
    public Input RightController;
    public Input LeftController;

    private InputData inputdata;
    public float leftTriggerValue;
    private void Start()
    {
        inputdata = GetComponent<InputData>();
    }

    private void Update()
    {
        if (inputdata._leftController.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            //_leftMaxScore = theFloat;
            leftTriggerValue = triggerValue;
            
        }
    }
    public float GetLeftTriggerValue()
    {
        return leftTriggerValue;
    }
}
