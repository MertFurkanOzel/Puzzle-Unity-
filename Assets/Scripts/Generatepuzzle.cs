using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generatepuzzle : MonoBehaviour
{
    public int size;
    public int[] dizi;
    public string[] rows;
    public string[] columns;
    public void Start ()
    {
        size = PlayerPrefs.GetInt("size");
        rows = new string[size];
        columns = new string[size];
        generate();
        numprint();

    }
   public void generate()
    {
        destroysqchild();
        dizi = new int[size * size];
        for(int i=0;i<dizi.Length;i++)
        {
            if (i % size == 0 && i > 0)
                Debug.Log("------");

            if (0 == Random.Range(0, 4))
                dizi[i] = 0;
            else
                dizi[i] = 1;

            Debug.Log(dizi[i]);           
        }      
    }
    void numprint()
    {
        //COLUMNS
        int saycolumns = 0;
        for(int i=0;i<columns.Length;i++)
        {
            for(int j=i*(size);j<(size*i)+size;j++)
            {
                if(dizi[j]==1)
                {
                    saycolumns++;
                    if(j== (size * i) + size-1)
                    {
                        if(columns[i] != null)
                        columns[i] += "," + saycolumns.ToString();
                        else
                        columns[i] += saycolumns.ToString();
                        saycolumns = 0;
                    }
                        
                }
                else if (saycolumns > 0 )
                {
                    if (columns[i] != null)
                        columns[i] +=","+saycolumns.ToString();
                    else
                        columns[i] += saycolumns.ToString();   
                    saycolumns = 0;
                }
            }
            Debug.Log(columns[i]);
        }
        Debug.Log("@@@@@@@");

        //ROWS

        int sayrows = 0;

        for(int i=0;i<rows.Length;i++)
        {
            for (int j = i; j <(size*(size-1)+i+1); j+=size)
            {
                if (dizi[j] == 1)
                {
                    sayrows++;
                    if (j == (size * (size - 1) + i))
                    {
                        if (rows[i] != null)
                            rows[i] += "," + sayrows.ToString();
                        else
                            rows[i] += sayrows.ToString();
                        sayrows = 0;
                    }

                }
                else if (sayrows > 0)
                {
                    if (rows[i] != null)
                        rows[i] += "," + sayrows.ToString();
                    else
                        rows[i] += sayrows.ToString();
                    sayrows = 0;
                }
            }
            Debug.Log(rows[i]);
        }
    }

    public void destroysqchild()
    {
        for(int i=0;i<GameObject.Find("Squares").transform.childCount;i++)
        {
            Destroy(GameObject.Find("Squares").transform.GetChild(i).gameObject);
        }
    }
}
   
