using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSwitchZone : MonoBehaviour
{
    public bool NoSwitch;

    private void Start()
    {
        NoSwitch = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NoSwitchZone")
        {
            NoSwitch = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NoSwitchZone")
        {
            NoSwitch = false;
        }
    }
}
