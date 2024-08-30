using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLevel : MonoBehaviour
{
    [SerializeField] private string NextSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Portal Touched : ");
            Debug.Log(NextSceneName);
            EnterScene(); 
        }
    }

    public void EnterScene()
    {
        SceneManager.LoadScene(NextSceneName);
        Time.timeScale = 1f;
    }
}