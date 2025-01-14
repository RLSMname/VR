using System;
using UnityEngine;

public class CubeSceneSelector : MonoBehaviour
{
    public GameObject menuUI;
    public GameObject buttonToActivate;
    void Start()
    {
        if (menuUI != null)
        {
            menuUI.SetActive(false); //hide on start
           
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.transform.position.y >= transform.position.y)
            {
                if (menuUI != null)
                {
                    menuUI.SetActive(true);
                    if (buttonToActivate != null)
                    {
                        buttonToActivate.SetActive(true);
                    }
                }
            }
        }
    }
}