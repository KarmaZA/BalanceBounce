using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    public Button button;
    private void Start()
    {
        button.onClick.AddListener(QuitGame);
    }
    public void QuitGame()
    {
        Debug.Log("test");
        Application.Quit(); //Test this with fully built app
    }
}
