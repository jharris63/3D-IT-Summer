using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ramManager : MonoBehaviour {

    public GameObject[] brackets;
    public GameObject ram0;
    public GameObject ram1;
    public GameObject ram2;
    public GameObject ram3;

    public GameObject[] Ram;

    public slotColliders slots;

    public bool isOpen = false;
    public Text instruction;
    public int holdObj;

    // Use this for initialization
    void Start ()
    {
        ram0.GetComponent<ObjectDrag>().enabled = false;
        ram1.GetComponent<ObjectDrag>().enabled = false;
        ram2.GetComponent<ObjectDrag>().enabled = false;
        ram3.GetComponent<ObjectDrag>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Open();
        if (Open() == true)
        {
            isOpen = true;
        }


        if (isOpen == true)
        {
            instruction.text = "Move RAM stick over to sockets";

            ram0.GetComponent<ObjectDrag>().enabled = true;
            ram1.GetComponent<ObjectDrag>().enabled = true;
            ram2.GetComponent<ObjectDrag>().enabled = true;
            ram3.GetComponent<ObjectDrag>().enabled = true;

            if (slots.insert == true)
            {
                ram0.GetComponent<ObjectDrag>().enabled = false;
                ram1.GetComponent<ObjectDrag>().enabled = false;
                ram2.GetComponent<ObjectDrag>().enabled = false;
                ram3.GetComponent<ObjectDrag>().enabled = false;
            }
            else
            {
                ram0.GetComponent<ObjectDrag>().enabled = true;
                ram1.GetComponent<ObjectDrag>().enabled = true;
                ram2.GetComponent<ObjectDrag>().enabled = true;
                ram3.GetComponent<ObjectDrag>().enabled = true;
            }

            if (ram0.GetComponent<ObjectDrag>().hold == true)
            {
                ram1.GetComponent<ObjectDrag>().enabled = false;
                ram2.GetComponent<ObjectDrag>().enabled = false;
                ram3.GetComponent<ObjectDrag>().enabled = false;
            }

            if (ram1.GetComponent<ObjectDrag>().hold == true)
            {
                ram0.GetComponent<ObjectDrag>().enabled = false;
                ram2.GetComponent<ObjectDrag>().enabled = false;
                ram3.GetComponent<ObjectDrag>().enabled = false;
            }

            if (ram2.GetComponent<ObjectDrag>().hold == true)
            {
                ram1.GetComponent<ObjectDrag>().enabled = false;
                ram0.GetComponent<ObjectDrag>().enabled = false;
                ram3.GetComponent<ObjectDrag>().enabled = false;
            }

            if (ram3.GetComponent<ObjectDrag>().hold == true)
            {
                ram1.GetComponent<ObjectDrag>().enabled = false;
                ram2.GetComponent<ObjectDrag>().enabled = false;
                ram0.GetComponent<ObjectDrag>().enabled = false;
            }
        }
	}

    private bool Open()
    {
        for (int i = 0; i < brackets.Length; i++)
        {
            if (brackets[i].GetComponent<Animator>().GetBool("open") == false)
            {
                return false;
            }
        }

        return true;
    }
}
