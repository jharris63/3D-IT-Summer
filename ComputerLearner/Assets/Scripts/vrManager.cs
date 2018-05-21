using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class vrManager : MonoBehaviour {

    public bool isVR;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(isVR == true)
        {
            StartCoroutine(SwitchToVR());
        }

        if (isVR == false)
        {
            StartCoroutine(SwitchOutOfVr());
        }
    }

    
    IEnumerator SwitchToVR()
    {
        string desiredDevice = "cardboard"; // Or "cardboard". Note, strings are lowercase.

        
        if (UnityEngine.XR.XRSettings.loadedDeviceName == desiredDevice)
        {
            // Workaround for issue # 826, VR device already loaded.
            yield break;
        }
        

        UnityEngine.XR.XRSettings.LoadDeviceByName(desiredDevice);

        // Wait one frame!
        yield return null;

        // Now it's ok to enable VR mode.
        UnityEngine.XR.XRSettings.enabled = true;
    }

    IEnumerator SwitchOutOfVr()
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(""); // Empty string loads the "None" device.

        // Wait one frame!
        yield return null;

        // Not needed, loading the None (`""`) device automatically sets `XRSettings.enabled` to `false`.
        // XRSettings.enabled = false;

        // If you only have one camera in your scene, you can just call `Camera.main.ResetAspect()` instead.
        ResetCameras();
    }

    // Resets local rotation and calls `ResetAspect()` on all enabled VR cameras.
    void ResetCameras()
    {
        // Camera looping logic copied from GvrEditorEmulator.cs
        for (int i = 0; i < Camera.allCameras.Length; i++)
        {
            Camera cam = Camera.allCameras[i];
            if (cam.enabled && cam.stereoTargetEye != StereoTargetEyeMask.None)
            {

                // Reset local rotation. (Only required if you change the local rotation while in non-VR mode.)
                cam.transform.localRotation = Quaternion.identity;

                // Reset local position. (Only required if you change the local position while in non-VR mode.)
                cam.transform.localPosition = Vector3.zero;

                // Reset aspect ratio based on normal (non-VR) screen size.
                // Required in certain versions of Unity, see github.com/googlevr/gvr-unity-sdk/issues/628
                cam.ResetAspect();

                // Don't need to reset camera `fieldOfView`, since it's restored to the original value automatically.
            }
        }
    }
}
