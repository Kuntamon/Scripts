using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
 public void MainMenu()
    {
        Debug.Log("MainMenu was pressed");

        SceneManager.LoadScene("MainMenu");
    }
}
