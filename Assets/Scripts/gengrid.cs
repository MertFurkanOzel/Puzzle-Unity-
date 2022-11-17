using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class gengrid : MonoBehaviour
{
    GameObject square;
    public GameObject sq1;
    public GameObject sq2;
    int size;
    public float space;
    public Canvas cnv;
    public GameObject panel;


    // Start is called before the first frame update
    private void Start()
    {
        size = PlayerPrefs.GetInt("size");
        gen();
    }

    // Update is called once per frame
    void gen()
    {
        
        string[] rows = GetComponent<Generatepuzzle>().rows;
        string[] columns = GetComponent<Generatepuzzle>().columns;
        int x;
        int y;
        int scalex = lenght(columns);
        int scaley =lenght(rows);
        for (int i=0;i<(size+1)*(size+1);i++)
        {
            x = i % (size + 1);
            y = i / (size + 1);
            if (i==0)
            continue;
            if (x % 5 == 0 && ((x!=0)&&y!=0)|| (y%5==0) && (x != 0 && y != 0))
            {
                square = sq2;
            }
            else
                square = sq1;

            GameObject temp = Instantiate(square, GameObject.Find("Squares").transform);
            temp.SetActive(true);
            
            float posx =x * space;
            float posy =y * -space;
            if (x==0)
            {
                
                //temp.transform.localScale = new Vector3(scalex, 1, 1);
                //temp.transform.position = new Vector2(posx-(scalex*space*space), posy);
                temp.transform.position = new Vector2(posx, posy);
                temp.GetComponent<sqsc>().k = false;
                //TextMeshProUGUI tx = Instantiate(text, temp.transform);
                //tx.text = columns[y - 1];
                //tx.transform.localScale=new Vector3(1, scalex, 1);
                //tx.transform.position = new Vector3(960+posx, posy+ 540, 1);
                if(scalex>3)
                {
                    float deger = scalex / (float)3;
                    temp.transform.localScale = new Vector3(deger, 1, 1);
                    temp.transform.GetChild(0).localScale = new Vector3(1,deger, 1);
                    temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontSize /=scalex/(float)4;
                    temp.transform.position = new Vector2(((deger*space)-space)/-2 ,posy);
                    
                }
                 
                temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = columns[y- 1];
                

            }

            else if(y==0)
            {
                // temp.transform.localScale = new Vector3(1, scaley, 1);
                //temp.transform.position = new Vector2(posx, posy+(scaley*space*space));
                temp.transform.position = new Vector2(posx, posy);
                temp.GetComponent<sqsc>().k = false;
                if(scaley>3)
                {
                    float deger = scaley / (float)3;
                    temp.transform.localScale = new Vector3(1, deger, 1);
                    temp.transform.GetChild(0).localScale = new Vector3(deger, 1, 1);
                    temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontSize /= scaley / (float)4;
                    temp.transform.position = new Vector2(posx, ((deger * space) - space) /2);

                }
                string r = rows[x-1];
                for(int k=0;k<r.Length;k++)
                {
                    if(r[k]!=',')
                    temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text +=r[k];
                    else
                    temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text +="\n";

                }

            }
            else
            temp.transform.position = new Vector2(posx, posy);
            
            //else if (y == 0)
            //  temp.transform.localScale = new Vector3(1, 5, 1);
        }
        panel.SetActive(true);
        panel.transform.position = new Vector3(space *size*0.7f,size*0.1f,1);
        panel.transform.localScale = new Vector3(size / 5, size / 5, 1);
    }
    int lenght(string [] dizi)
    {
        
        int max = 0;
        for(int k=0;k<dizi.Length;k++)
        {
            if (dizi[k].Length > max)
                max = dizi[k].Length;
        }
        return max;
    }
    
}
