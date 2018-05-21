using UnityEngine;

public class CamRotate : MonoBehaviour
{
    protected float fDistance = 1;
    protected float fSpeed = 1;
    public GameObject Point;

    public bool TurnRight = true;
    public bool TurnLeft = true;

    // Update is called once per frame
    void Update()
    {
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
