using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject Printer;
    public float turnSpeed = 50f;

    public bool TurnRight;
    public bool TurnLeft;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(TurnRight)
        {
            Printer.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        if(TurnLeft)
        {
            Printer.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
    }

    public void OnPressR()
    {
        TurnRight = true;
    }

    public void OnReleaseR()
    {
        TurnRight = false;
    }

    public void OnPressL()
    {
        TurnLeft = true;
    }

    public void OnReleaseL()
    {
        TurnLeft = false;
    }
}