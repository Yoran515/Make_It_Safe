using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TimeVideo : MonoBehaviour
{
    public float time;
    public TMP_Text m_TextMeshPro;

   

    public GameObject Danger1;
    // Start is called before the first frame update
    void Start()
    {
        Danger1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        m_TextMeshPro.SetText(time.ToString());
        time += Time.deltaTime;

        if(time >= 7f&& time < 8)
        {
            Danger1.SetActive(true);
        }
    }
    
        
    
}
