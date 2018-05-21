using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour {

    public float distance = 10;

    public bool hold;
    public GameObject Redicle;

    void Start()
    {
        
    }

    void Update()
    {
        if(Redicle == null)
        {
            Redicle = GameObject.Find("GvrReticlePointer");
        }

        if(hold == true)
        {
            Ray ray = new Ray(Redicle.transform.position, Redicle.transform.forward);
            transform.position = ray.GetPoint(distance);
        }


    }

    public void OnPress()
    {
        hold = !hold;
    }

    public void OnRelease()
    {
        hold = false;
    }
}
