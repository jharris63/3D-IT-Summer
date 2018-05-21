using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampManager : MonoBehaviour {

    public bool insert = false;
    public Animator animator;
    public bool fin = false;

	// Update is called once per frame
	void Update () {
		if(insert == true)
        {
            animator.SetBool("click", true);
            fin = true;
        }
	}

    public void OnPress()
    {
        insert = true;
    }
}
