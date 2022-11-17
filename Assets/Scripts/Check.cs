using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Check : MonoBehaviour
{
    int[] dizi1;
    int[] dizi2;
    int size;
    GameObject go;
    GameObject go2;
    public Sprite sp1;
    public TextMeshProUGUI sure;
    public TextMeshProUGUI kalankaresayisi;
    Image img;
    
    private void Start()
    {
        go = GameObject.Find("GController");
        go2 = GameObject.Find("Squares");
        
    }

    public void karsilastir()
    {
        dizi1 = go.GetComponent<Generatepuzzle>().dizi;
        size = (int)Mathf.Sqrt(dizi1.Length);
        dizi2 = new int[dizi1.Length];
        int say = 0;
        for(int i=0;i<dizi1.Length;i++)
        {
            int x = 1 + size + (i % size) + (i / size) * (size+1);
            img = go2.transform.GetChild(x).GetComponent<Image>();
            
              if (img.sprite == sp1)
                 dizi2[i] = 1;

              else
                 dizi2[i] = 0;

              if (dizi1[i] == dizi2[i]) 
                say++;

              Debug.Log(dizi2[i]);

        }

        if(say==dizi2.Length)
        {
            PlayerPrefs.SetString("sure", sure.text);
            SceneManager.LoadScene(2);
        }
        else
        {
            kalankaresayisi.gameObject.SetActive(true);
            kalankaresayisi.text = (dizi2.Length - say).ToString() + " hamle daha";
            Invoke("kaybet", 1f);
        }
       
        
    }
    void kaybet()
    {
        kalankaresayisi.gameObject.SetActive(false);
    }
    
}
