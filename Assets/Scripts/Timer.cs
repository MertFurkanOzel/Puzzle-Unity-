using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI tx;
    public float time;
    // Update is called once per frame
    void Update()
    {
        time +=Time.deltaTime;
        tx.text = System.Math.Round(time, 1).ToString()+" s";
    }
}
