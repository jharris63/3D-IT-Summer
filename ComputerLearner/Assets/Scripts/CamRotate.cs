using UnityEngine;

public class RtsCamera : MonoBehaviour
{
    protected float fDistance = 1;
    protected float fSpeed = 1;
    public GameObject Point;

    public bool TurnRight = true;
    public bool TurnLeft = true;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.RightArrow)) OrbitTower(false);
        //if (Input.GetKey(KeyCode.LeftArrow)) OrbitTower(true);


        float step = fSpeed * Time.deltaTime;
        float fOrbitCircumfrance = 2F * fDistance * Mathf.PI;
        float fDistanceDegrees = (fSpeed / fOrbitCircumfrance) * 360;
        float fDistanceRadians = (fSpeed / fOrbitCircumfrance) * 2 * Mathf.PI;

        if (TurnRight == false)
        {
            transform.RotateAround(Point.transform.position, Vector3.up, -fDistanceRadians);
        }

        if (TurnLeft == false)
        {
            transform.RotateAround(Point.transform.position, Vector3.up, fDistanceRadians);
        }
    }
/*
    protected void OrbitTower(bool bLeft)
    {
        float step = fSpeed * Time.deltaTime;
        float fOrbitCircumfrance = 2F * fDistance * Mathf.PI;
        float fDistanceDegrees = (fSpeed / fOrbitCircumfrance) * 360;
        float fDistanceRadians = (fSpeed / fOrbitCircumfrance) * 2 * Mathf.PI;
        if (bLeft)
        {
            transform.RotateAround(Point.transform.position, Vector3.up, -fDistanceRadians);
        }
        else
            transform.RotateAround(Point.transform.position, Vector3.up, fDistanceRadians);

        if(TurnRight)
        {
            transform.RotateAround(Point.transform.position, Vector3.up, -fDistanceRadians);
        }

        if(TurnLeft)
        {
            transform.RotateAround(Point.transform.position, Vector3.up, fDistanceRadians);
        }
    }
*/
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
