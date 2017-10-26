using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIButtons : MonoBehaviour
{

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void closeApp()
    {
        Application.Quit();
    }

}
