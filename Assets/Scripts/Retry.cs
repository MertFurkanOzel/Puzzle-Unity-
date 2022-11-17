using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Retry : MonoBehaviour
{
    // Start is called before the first frame update
    public void retr()
    {

        GetComponent<Timer>().time = 0;
        GameObject sq= GameObject.Find("Squares");
        int size = (int)Mathf.Sqrt(sq.transform.childCount+1)-1;
       
        for (int i=0;i<size*size; i++)
        {
           int x = 1 + size + (i % size) + (i / size) * (size + 1);
           
           sq.transform.GetChild(x).GetComponent<Image>().sprite = sq.transform.GetChild(x).GetComponent<sqsc>().orj;
           sq.transform.GetChild(x).GetComponent<sqsc>().degistirilmis = false;

        }
        
    }
}
