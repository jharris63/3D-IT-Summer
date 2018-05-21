using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatSink_Manager : MonoBehaviour {
    public GameObject Clamp0;
    public GameObject Clamp1;
    public bool fin = false;

    private bool EnteredTrigger = false;

    // Use this for initialization
    void Start () {
        Clamp1.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(EnteredTrigger == true)
        {
            Clamp0.SetActive(false);
            Clamp1.SetActive(true);
            fin = true;
        }
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "clamp")
        {
            EnteredTrigger = true;
        }
    }
}
