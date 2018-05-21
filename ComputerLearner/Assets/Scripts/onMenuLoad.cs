using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMenuLoad : MonoBehaviour
{
    public GameObject playerData;

    void Awake()
    {
        if (playerData == null)
        {
            playerData = GameObject.Find("PlayerData");
        }
    }

    // Use this for initialization
    void Start ()
    {
        playerData.GetComponent<vrManager>().isVR = true;
	}
}
