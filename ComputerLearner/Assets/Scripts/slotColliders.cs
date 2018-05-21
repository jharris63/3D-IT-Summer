using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotColliders : MonoBehaviour {

    public bool insert = false;
    public bool right = false;
    public GameObject submit;
    public GameObject pass;
    public GameObject fail;

    public Animator[] anim;
    public GameObject[] RAM;
    public GameObject[] UI;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        submit.SetActive(AllRamInstalled());

        if (RAM[0].GetComponent<stickInsert>().done == true)
        {
            insert = false;

            if(insert == false)
            {
                UI[0].SetActive(false);
            }
        }
        if (RAM[1].GetComponent<stickInsert>().done == true)
        {
            insert = false;

            if (insert == false)
            {
                UI[1].SetActive(false);
            }
        }
        if (RAM[2].GetComponent<stickInsert>().done == true)
        {
            insert = false;

            if (insert == false)
            {
                UI[2].SetActive(false);
            }
        }
        if (RAM[3].GetComponent<stickInsert>().done == true)
        {
            insert = false;

            if (insert == false)
            {
                UI[3].SetActive(false);
            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "RAM0")
        {
            insert = true;
            RAM[0].SetActive(true);
            UI[0].SetActive(true);

            col.gameObject.GetComponent<ObjectDrag>().hold = false;
            col.gameObject.GetComponent<ObjectDrag>().enabled = false;
            col.gameObject.SetActive(false);
        }

        if (col.gameObject.name == "RAM1")
        {
            insert = true;
            RAM[1].SetActive(true);
            UI[1].SetActive(true);

            col.gameObject.GetComponent<ObjectDrag>().hold = false;
            col.gameObject.GetComponent<ObjectDrag>().enabled = false;
            col.gameObject.SetActive(false);
        }

        if (col.gameObject.name == "RAM2")
        {
            insert = true;
            RAM[2].SetActive(true);
            UI[2].SetActive(true);

            col.gameObject.GetComponent<ObjectDrag>().hold = false;
            col.gameObject.GetComponent<ObjectDrag>().enabled = false;
            col.gameObject.SetActive(false);
        }

        if (col.gameObject.name == "RAM3")
        {
            insert = true;
            RAM[3].SetActive(true);
            UI[3].SetActive(true);

            col.gameObject.GetComponent<ObjectDrag>().hold = false;
            col.gameObject.GetComponent<ObjectDrag>().enabled = false;
            col.gameObject.SetActive(false);
        }
    }

    private bool AllRamInstalled()
    {
        for (int i = 0; i < RAM.Length; ++i)
        {
            if (RAM[i].GetComponent<stickInsert>().done == false)
            {
                return false;
            }
        }
        return true;
    }

    private bool AllRamRight()
    {
        for (int i = 0; i < RAM.Length; ++i)
        {
            if (RAM[i].GetComponent<stickInsert>().right == false)
            {
                return false;
            }
        }
        return true;
    }

    public void Submit()
    {
        submit.SetActive(false);

        if(AllRamRight() == true)
        {
            pass.SetActive(true);
        }

        if(AllRamRight() == false)
        {
            fail.SetActive(true);
        }
    }
}
