using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolantManager : MonoBehaviour {

    public GameObject Coolant0;
    public GameObject Coolant1;
    public GameObject Coolant2;
    public GameObject Coolant3;
    public GameObject Bead;
    public GameObject BeadCoolant;

    public GameObject MoreButt;
    public GameObject FailMenu;
    public GameObject MoboUI;
    public GameObject CoolantUI;

    public int CoolantAmount = 0;

    public bool Finished = false;
    public bool Finalpress = false;

    // Use this for initialization
    void Start () {
        Coolant0.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		if(CoolantAmount == 0)
        {
            Coolant0.SetActive(true);
            Coolant1.SetActive(false);
            Coolant2.SetActive(false);
            Coolant3.SetActive(false);
        }
        if (CoolantAmount == 1)
        {
            Coolant0.SetActive(false);
            Coolant1.SetActive(true);
            Coolant2.SetActive(false);
            Coolant3.SetActive(false);
        }
        if (CoolantAmount == 2)
        {
            Coolant0.SetActive(false);
            Coolant1.SetActive(false);
            Coolant2.SetActive(true);
            Coolant3.SetActive(false);
        }
        if (CoolantAmount == 3)
        {
            Coolant0.SetActive(false);
            Coolant1.SetActive(false);
            Coolant2.SetActive(false);
            Coolant3.SetActive(true);
        }
        
        if (CoolantAmount > 2 && CoolantAmount < 9999)
        {
            MoreButt.SetActive(false);
        }

        if (CoolantAmount == 9999)
        {
            Coolant0.SetActive(false);
            Coolant1.SetActive(false);
            Coolant2.SetActive(false);
            Coolant3.SetActive(false);
        }

        if(CoolantAmount == 2)
        {
            Finished = true;
        }
        else
        {
            Finished = false;
        }
    }

    public void OnClick()
    {
        CoolantAmount += 1;
    }

    public void FinalClick()
    {
        if(Finished == true)
        {
            CoolantAmount = 9999;
            Bead.SetActive(true);
            BeadCoolant.SetActive(true);
            Coolant2.SetActive(false);
            Finalpress = true;
        }
        else
        {
            FailMenu.SetActive(true);
            MoboUI.SetActive(false);
        }
    }
}
