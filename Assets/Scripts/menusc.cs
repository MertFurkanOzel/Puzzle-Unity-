using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menusc : MonoBehaviour
{
    // Start is called before the first frame update
    public void btnclick(int size)
    {
        PlayerPrefs.SetInt("size", size);
        SceneManager.LoadScene(1);
    }       
}
