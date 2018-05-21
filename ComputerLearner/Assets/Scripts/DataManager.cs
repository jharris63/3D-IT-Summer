using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {

    public GameObject PlayerData;

    void Awake()
    {
        GameObject Spawn = (GameObject)Instantiate(PlayerData);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
