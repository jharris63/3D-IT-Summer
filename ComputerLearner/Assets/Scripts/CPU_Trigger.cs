using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPU_Trigger : MonoBehaviour {
    public GameObject Coolant0;
    public GameObject Coolant1;

    public Text instruction;
    public GameObject ApplyCanvas;
    private bool EnteredTrigger = false;
    public GameObject Manager;
    public GameObject floorTrig;
    public GameObject HeatSink;
    public GameObject HeatSinkMounted;
    public GameObject clamp;
    public bool heatSinkEnteredTrigger = false;

    // Use this for initialization
    void Start () {
        Coolant1.SetActive(false);
        HeatSinkMounted.SetActive(false);
        HeatSink.GetComponent<ObjectDrag>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (EnteredTrigger == true)
        {
            Coolant1.SetActive(true);
            ApplyCanvas.SetActive(true);
            Coolant0.SetActive(false);

            instruction.text = "Apply Correct Coolant Amount";
            GetComponent<Collider>().enabled = false;
            Manager.GetComponent<CoolantManager>().enabled = true;
        }
        if (EnteredTrigger == false)
        {
            Coolant1.SetActive(false);
            ApplyCanvas.SetActive(false);
            Coolant0.SetActive(true);
            instruction.text = "Move Coolant To CPU";
            Manager.GetComponent<CoolantManager>().enabled = false;
        }

        if(Manager.GetComponent<CoolantManager>().Finalpress == true)
        {
            GetComponent<Collider>().enabled = true;
            ApplyCanvas.SetActive(false);
            instruction.text = "Move Coolant To Coolant To Side";

            if(floorTrig.GetComponent<floorTrigger>().floorTriggered == true)
            {
                instruction.text = "Move Heatsink To CPU";
                HeatSink.GetComponent<ObjectDrag>().enabled = true;

                if(heatSinkEnteredTrigger == true)
                {
                    HeatSink.SetActive(false);
                    HeatSinkMounted.SetActive(true); 
                    instruction.text = "Move Clamp To Heatsink";
                }
            }
        }

        if(HeatSinkMounted.GetComponent<HeatSink_Manager>().fin == true)
        {
            instruction.text = "Insert Heatsink Clamp";
        }

        if(clamp.GetComponent<ClampManager>().fin == true)
        {
            instruction.text = "Tighten Heatsing Clamp Lever";
        }
        

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CPU")
        {
            EnteredTrigger = true;
        }

        if(other.tag == "heatSink")
        {
            heatSinkEnteredTrigger = true;
        }

    }
}
