using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MainMenu_UI : MonoBehaviour
{
    [SerializeField] private GameObject StartMenu;
    [SerializeField] private GameObject LevelMenu;

    void Start()
    {
        OpenStartMenu();
    }

    public void OpenStartMenu()
    {
        StartMenu.gameObject.SetActive(true);
        LevelMenu.gameObject.SetActive(false);
    }

    public void OpenLevelMenu()
    {
        StartMenu.gameObject.SetActive(false);
        LevelMenu.gameObject.SetActive(true);
    }
}
