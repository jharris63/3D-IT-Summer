using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class zeroForce : MonoBehaviour {

    public Animator animator;
    public bool open = false;
    public GameObject CPU;
    public Text instruction;
    public GameObject CPUstatic;

    // Use this for initialization
    void Start () {
        instruction.text = "Unlock Zero Force Lever";
    }
	
	// Update is called once per frame
	void Update () {



    }

    public void Open()
    {
        if(open == false)
        {
            animator.SetBool("open", true);
            open = true;
            CPU.GetComponent<ObjectDrag>().enabled = true;
            instruction.text = "Place CPU Chip on CPU Socket";
        }
        else if(open == true)
        {
            animator.SetBool("open", false);
            open = false;
            CPU.GetComponent<ObjectDrag>().enabled = false;
            instruction.text = "Unlock Zero Force Lever";
        }       
    }
}
