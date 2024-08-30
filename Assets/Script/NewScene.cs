using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    // This is a test script please ignore :)
    //[SerializeField] private string NextScene = "Stage 2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") SceneManager.LoadScene(2);
    }
}
