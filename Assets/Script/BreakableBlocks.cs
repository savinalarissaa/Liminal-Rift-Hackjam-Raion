using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBlocks : MonoBehaviour
{
    private WorldSwitch worldSwitch;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            worldSwitch = collision.gameObject.GetComponent<WorldSwitch>();
            if(worldSwitch.worldIndex == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
