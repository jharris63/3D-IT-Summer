using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    public InputField UsernameUI;
    public InputField PasswordUI;
    public Text LoginError;
    public bool LoginSuccess = false;
    public GameObject PlayerData;
    public int lessonNum;
    public bool LoginVerified = false;
    public GameObject MenuUI;
    public GameObject InsertUI;

    string LoginURL = "http://3dit.mygamesonline.org/Login.php";

	
	// Update is called once per frame
	void Update ()
    {

        if(LoginSuccess == true)
        {
            PlayerData.GetComponent<PlayerData>().Username = UsernameUI.text;
            PlayerData.GetComponent<PlayerData>().Lesson = lessonNum;
            StartCoroutine(FetchLessonData(UsernameUI.text));
            LoginVerified = true;
        }
    }

#region LoginToDataBase
    IEnumerator LoginToDB(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);

        WWW www = new WWW(LoginURL, form);
        yield return www;
        Debug.Log(www.text);

        if (www.text == "Incorrect password")
        {
            LoginError.text = "Incorrect password";
            StartCoroutine(ErrorFade(1.0f));
        }

        if(www.text == "user not found")
        {
            LoginError.text = "Username not found";
            StartCoroutine(ErrorFade(1.0f));
        }

        if(www.text == "Login Success")
        {
            LoginSuccess = true;
        }

    }
    #endregion

#region FetchLessonData
    IEnumerator FetchLessonData(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        WWW lessonData = new WWW("http://3dit.mygamesonline.org/UserLessonData.php", form);
        yield return lessonData;
        Debug.Log(lessonData.text);

        int.TryParse(lessonData.text, out lessonNum);
    }
#endregion

#region UI_Fader
    IEnumerator ErrorFade(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        LoginError.text = "";
    }
    #endregion

#region OnClick
    public void OnClick()
    {
        StartCoroutine(LoginToDB(UsernameUI.text, PasswordUI.text));

        if(LoginVerified == true)
        {
            MenuUI.SetActive(false);
            InsertUI.SetActive(true);
        }
    }
#endregion

}
