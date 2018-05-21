using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorTrigger : MonoBehaviour {
    public bool floorTriggered = false;
    private bool EnteredTrigger = false;
    public GameObject BeadCool;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (EnteredTrigger == true)
        {
            floorTriggered = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coolant")
        {
            EnteredTrigger = true;
            BeadCool.GetComponent<ObjectDrag>().enabled = false;
        }

    }
}
