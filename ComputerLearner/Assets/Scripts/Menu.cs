using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

    public string LevelToLoad;
    public GameObject PlayerData;

    void Awake()
    {
        if(PlayerData == null)
        {
            PlayerData = GameObject.Find("PlayerData(Clone)");
        }
    }

    public void loadScene() {
        SceneManager.LoadScene(LevelToLoad);
        
    }

}
