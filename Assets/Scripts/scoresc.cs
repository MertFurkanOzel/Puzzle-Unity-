using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class scoresc : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        string sure = PlayerPrefs.GetString("sure");
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = sure + " sürede tamamladınız";
    }
    public void quit()
    {
        Application.Quit();
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
