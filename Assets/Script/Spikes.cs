using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    [SerializeField] private string namaScene;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ResetScene();
        }   
    }

    private void ResetScene()
    {
        SceneManager.LoadScene(namaScene);
    }
}
