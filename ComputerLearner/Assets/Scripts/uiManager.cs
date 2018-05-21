using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiManager : MonoBehaviour {

    public GameObject lever;
    public GameObject MoboUI;
    public GameObject FinalUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(lever.GetComponent<LeverManager>().fin == true)
        {
            MoboUI.SetActive(false);
            FinalUI.SetActive(true);
        }
		
	}
}
