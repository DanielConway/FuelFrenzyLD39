using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneControl : MonoBehaviour {

    void Awake()
    {
        Application.targetFrameRate = 60;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
