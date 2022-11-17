using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class sqsc : MonoBehaviour,IPointerDownHandler
{
    public bool degistirilmis;
    public bool k;
    public Sprite bir;
    public Sprite x;
    Image img;
    public Sprite orj;
    Slider sld;
    private void Awake()
    {
        k = true;
        img = GetComponent<Image>();
        orj = img.sprite;
        sld = GameObject.Find("Slider").GetComponent<Slider>();
    }
  

    public void OnPointerDown(PointerEventData eventData)
    {
         if(k&&!degistirilmis)
         {
            
            
            if (sld.value==0)
            {
                
                img.sprite = bir;
                degistirilmis = true;
            }
             else
             {
                
                img.sprite = x;
                degistirilmis = true;
             }
         }
         else if(degistirilmis&&k)
         {
            img.sprite = orj;
            degistirilmis = false;
         }
        
        
        
    }

   /* public void OnPointerEnter(PointerEventData eventData)
    {
        if (k && !degistirilmis&&ilk)
        {

            //ilk = false;
            if (sld.value == 0)
            {

                img.sprite = bir;
                degistirilmis = true;
            }
            else
            {

                img.sprite = x;
                degistirilmis = true;
            }
        }
        else if (degistirilmis && k&&ilk)
        {
            //ilk = false;
            img.sprite = orj;
            degistirilmis = false;
        }
    }*/

    
}
