using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour {

    public bool tighten = false;
    public Animator animator;
    public bool fin = false;
    public GameObject Clamp;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Clamp.GetComponent<ClampManager>().fin == true)
        {
            if (tighten == true)
            {
                animator.SetBool("onClick", true);
                fin = true;
            }
        }

    }

    public void OnPress()
    {
        tighten = true;
    }
}
