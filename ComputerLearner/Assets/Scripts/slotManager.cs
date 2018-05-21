using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slotManager : MonoBehaviour
{
    public Animator WifiCardAnim;

    public GameObject wifiCardDrag;
    public GameObject wifiCardStatic;
    public GameObject wifiUI;
    public GameObject CompleteUI;
    public GameObject FailUI;

    public GameObject Info;

    public bool collide = false;
    public bool rotate = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(collide == true)
        {
            wifiCardDrag.SetActive(false);
            wifiCardStatic.SetActive(true);
            wifiUI.SetActive(true);
        }

        if(wifiCardStatic.activeSelf == true)
        {
            collide = false;
            Info.GetComponent<Text>().text = "Orientate card to socket & insert it";
        }

        if(WifiCardAnim.GetCurrentAnimatorStateInfo(0).IsName("idleR"))
        {
            CompleteUI.SetActive(true);
        }

        if (WifiCardAnim.GetCurrentAnimatorStateInfo(0).IsName("idleW"))
        {
            FailUI.SetActive(true);
        }

    }

    public void Rotate()
    {
        rotate = !rotate;
        WifiCardAnim.SetBool("rotate", rotate);
    }

    public void Insert()
    {
        WifiCardAnim.SetBool("insert", true);
        wifiUI.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "WifiCard0")
        {
            collide = true;
        }
        else
        {
            collide = false;
        }
        
    }
}
