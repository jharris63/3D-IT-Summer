using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LessonComplete : MonoBehaviour {

    public string newLessonNum;
    public GameObject PlayerData;
    private int newLessonData;
    public bool UpdateLessonData = false;

    string LessonCompURL = "http://3dit.mygamesonline.org/LessonComp.php";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Space)) CreateUser(inputUserName, inputPassword, inputEmail);
        //PlayerData.GetComponent<PlayerData>().Lesson

        if(PlayerData == null)
        {
            PlayerData = GameObject.Find("PlayerData");
        }

        int.TryParse(newLessonNum, out newLessonData);

        if (PlayerData.GetComponent<PlayerData>().Lesson < newLessonData)
        {
            UpdateLessonData = true;
        }
	}

    public void SetLessonData(string username, int LessonNum)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("newLesson", LessonNum);

        WWW lessonData = new WWW(LessonCompURL, form);
    }

    public void OnClick()
    {
        if(UpdateLessonData == true)
        {
            SetLessonData(PlayerData.GetComponent<PlayerData>().Username, newLessonData);
            PlayerData.GetComponent<PlayerData>().Lesson = newLessonData;
        }
    }
}
