using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float ScoreValue;
    public TMP_Text Scoretext;
    public Transform ScoreLocation;
    private void Start()
    {
        ScoreValue = 0;
    }
    public void ScoreAdd()
    {
        ScoreValue =+ 1;
    }
    public void ShowText()
    {
        Instantiate(Scoretext, ScoreLocation.position, Quaternion.identity, transform);
    }
    private void Update()
    {
        Scoretext.SetText(ScoreValue.ToString());
    }


}
