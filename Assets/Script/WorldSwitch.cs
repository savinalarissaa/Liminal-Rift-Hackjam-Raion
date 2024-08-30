using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitch : MonoBehaviour
{
    public GameObject[] world1;
    public GameObject[] world2;
    //public NoSwitchZone noSwitchZone1;
    //public NoSwitchZone noSwitchZone2;

    //private NoSwitchZone noZone;

    public int worldIndex;

    void Start()
    {
        //noZone = GetComponent<NoSwitchZone>();
        worldIndex = -1;
        switchWorlds();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && Time.timeScale >= 1f)
        {
            Debug.Log("SWITCH");
            switchWorlds();
        }
    }

    private void switchWorlds()
    {
        worldIndex++;
        if (worldIndex >= 2) worldIndex = 0;

        if (worldIndex == 0)
        {
            for (int i = 0; i < world1.Length; i++)
            {
                world1[i].gameObject.SetActive(true);
                world2[i].gameObject.SetActive(false);
            }
        }

        if (worldIndex == 1)
        {
            for (int i = 0; i < world1.Length; i++)
            {
                world1[i].gameObject.SetActive(false);
                world2[i].gameObject.SetActive(true);
            }
        }
    }
}
