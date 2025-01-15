using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Console.WriteLine("TRYING WITH SCENE NAME: "+sceneName);
        SceneManager.LoadScene("Scenes/Level" + sceneName); 
    }

    public void CloseMenu()
    {
        Cursor.lockState = CursorLockMode.Locked;
        gameObject.SetActive(false); 
    }

}
