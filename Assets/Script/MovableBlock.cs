using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableBlock : MonoBehaviour
{
    public GameObject Player;
    //private Rigidbody2D rbPlayer;
    //private Player playerScript;
    //private Rigidbody2D rb;
    private bool playerInRange;
    //private bool isPulling = false;
    //private float moveDirection;
    
    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //playerScript = Player.GetComponent<Player>();
        //rbPlayer = Player.GetComponent<Rigidbody2D>();
        //isPulling = false;
    }

    private void Update()
    {
        //Debug.Log(isPulling);

        if (playerInRange && Input.GetKeyDown(KeyCode.T))
        {
            //isPulling = true;
            Pull();
            return;
        }

        if (Input.GetKeyUp(KeyCode.T)) 
        {
            Player.gameObject.transform.SetParent(null);
            //isPulling = false;
        }
    }

    private void Pull()
    {
        Player.gameObject.transform.SetParent(transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
