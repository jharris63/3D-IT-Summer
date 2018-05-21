using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CPU_Lock : MonoBehaviour {
    public GameObject CPU0;
    public GameObject CPU1;
    public bool EnteredTrigger;
    public Text instruction;
    public GameObject Lever;
    public GameObject InsertButton;
    public GameObject MoBoCanvas;
    public GameObject FinalCanvas;
    public Animator LeverAnimator;
    public string LevelToLoad;

    // Use this for initialization
    void Start () {
        EnteredTrigger = false;
        CPU1.SetActive(false);
        FinalCanvas.SetActive(false);
        CPU0.SetActive(true);
        InsertButton.SetActive(false);

        instruction.text = "Place CPU Chip on CPU Socket";
    }
	
	// Update is called once per frame
	void Update () {
        if(EnteredTrigger == true)
        {
            CPU1.SetActive(true);
            CPU0.SetActive(false);
            InsertButton.SetActive(true);
            instruction.text = "Rotate chip to align colored corners";
            GetComponent<Collider>().enabled = false;
            Lever.GetComponent<zeroForce>().open = false;
        }
        else
        if(Lever.GetComponent<zeroForce>().open && EnteredTrigger == false)
        {
            CPU1.SetActive(false);
            CPU0.SetActive(true);
            instruction.text = "Place CPU Chip on CPU Socket";
        }

        if (CPU1.GetComponent<cpuRotate>().Finished)
        {
            InsertButton.SetActive(false);
            instruction.text = "Close Zero Force Lever";
            Lever.GetComponent<zeroForce>().open = true;

            if(LeverAnimator.GetCurrentAnimatorStateInfo(0).IsName("zeroCloseIdle"))
            {
                MoBoCanvas.SetActive(false);
                FinalCanvas.SetActive(true);
            }
        }
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

    public void OnTriggerEnter(Collider other){
        if (other.tag == "CPU")
        {
            EnteredTrigger = true;
        }
            
    }

}
