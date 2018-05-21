using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserManager : MonoBehaviour {
    public GameObject playerData;
    public int LessonComp;

    public Color CompleteColor;
    public Color AssignedColor;

    public Button[] btn;

    public Button L1;
    public Button L2;
    public Button L3;
    public Button L4;
    public Button L5;
    public Button L6;
    public Button L7;
    public Button L8;
    public Button L9;
    public Button L10;


    // Use this for initialization
    void Awake () {
        if (playerData == null)
        {
            playerData = GameObject.Find("PlayerData");
        }
    }
	
	// Update is called once per frame
	void Update () {
        LessonComp = playerData.GetComponent<PlayerData>().Lesson;

#region ColorIfs
        if (LessonComp >= 1)
        {
            L1.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L1.GetComponent<Image>().color = AssignedColor;
        }

        if (LessonComp >= 2)
        {
            L2.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L2.GetComponent<Image>().color = AssignedColor;
        }

        if (LessonComp >= 3)
        {
            L3.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L3.GetComponent<Image>().color = AssignedColor;
        }

        if (LessonComp >= 4)
        {
            L4.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L4.GetComponent<Image>().color = AssignedColor;
        }

        if (LessonComp >= 5)
        {
            L5.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L5.GetComponent<Image>().color = AssignedColor;
        }

        if (LessonComp >= 6)
        {
            L6.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L6.GetComponent<Image>().color = AssignedColor;
        }

        if (LessonComp >= 7)
        {
            L7.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L7.GetComponent<Image>().color = AssignedColor;
        }

        if (LessonComp >= 8)
        {
            L8.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L8.GetComponent<Image>().color = AssignedColor;
        }

        if (LessonComp >= 9)
        {
            L9.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L9.GetComponent<Image>().color = AssignedColor;
        }

        if (LessonComp >= 10)
        {
            L10.GetComponent<Image>().color = CompleteColor;
        }
        else
        {
            L10.GetComponent<Image>().color = AssignedColor;
        }
#endregion


    }

    public void LogoutClick()
    {
        Destroy(playerData);
    }
}
