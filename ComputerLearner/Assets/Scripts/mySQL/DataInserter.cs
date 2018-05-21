
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInserter : MonoBehaviour {

    public InputField UsernameUI;
    public InputField PasswordUI;
    public InputField EmailUI;

    public Text CreateError;
    private bool Clear = false;
    private bool usernameLength = false;
    private bool emailVerify = false;

    //public string inputUserName;
    //public string inputPassword;
    //public string inputEmail;

    string CreateUserURL = "http://3dit.mygamesonline.org/InsertUser.php";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Space)) CreateUser(inputUserName, inputPassword, inputEmail);
	}

    IEnumerator Verification(string username, string email)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("email", email);

        WWW userData = new WWW("http://3dit.mygamesonline.org/Verification.php", form);
        yield return userData;

        Debug.Log(userData.text);

        if(userData.text == "true" && usernameLength == true && emailVerify == true)
        {
            Clear = true;
        }

        if(username.Length < 5)
        {
            CreateError.text = "Username must be longer than 5 characters";
            StartCoroutine(ErrorFade(1.0f));
        }
        else
        {
            usernameLength = true;
        }
        
        if(email.Contains("@"))
        {
            emailVerify = true;
        }
        else
        {
            CreateError.text = "Email incorrect.";
            StartCoroutine(ErrorFade(1.0f));
        }

        if(userData.text == "Username already exists, choose a different one")
        {
            CreateError.text = "Username already exists";
            StartCoroutine(ErrorFade(1.0f));
        }

        if (userData.text == "E-Mail already registered")
        {
            CreateError.text = "Email already registered";
            StartCoroutine(ErrorFade(1.0f));
        }

    }

    public void CreateUser(string username, string password, string email)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);
        form.AddField("emailPost", email);

        WWW www = new WWW(CreateUserURL, form);
    }
    IEnumerator ErrorFade(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        CreateError.text = "";
    }

    public void OnClick()
    {
        StartCoroutine(Verification(UsernameUI.text, EmailUI.text));

        if(Clear == true)
        {
            CreateUser(UsernameUI.text, PasswordUI.text, EmailUI.text);
            CreateError.text = "Account Registered, proceed to Login";
            Clear = false;
        }
    }
}
