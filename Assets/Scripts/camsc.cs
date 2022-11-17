using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camsc : MonoBehaviour
{
    int size;
    private void Start()
    {
        size = PlayerPrefs.GetInt("size");
        Invoke("camsize", .01f);
    }
    void camsize()
    {
        GameObject sq = GameObject.Find("Squares");
        switch (size)
        {
            case 5:
               sq.transform.localPosition += new Vector3(-500, 210, 1);
                GetComponent<Camera>().orthographicSize = 4;
                break;

            case 10:
                sq.transform.localPosition += new Vector3(-850, 400, 1);
                GetComponent<Camera>().orthographicSize = 6.7f;
                break;

            case 15:
                sq.transform.localPosition += new Vector3(-1250, 620, 1);
                GetComponent<Camera>().orthographicSize = 9.6f;

                break;
            default:
                break;
        }
    }
}
