using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraMov : MonoBehaviour {

    PlayerController pc;

    GameController gc;

    public Text ScoreTxt;

    public GameObject endPanel;
    public GameObject gamePanel;

    public bool EndDeath = false;

	// Use this for initialization
	void Start () {
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
        gc = GameObject.Find("Scripts").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {

        if (gc.pause != true)
        {
            
            if (pc.Dead)
            {
                EndDeath = true; 
            }

            if (EndDeath)
            {

                gamePanel.SetActive(false);

                ScoreTxt.text = "Score: " + gc.score;

                if (endPanel.transform.localScale.y <= 1)
                {
                    endPanel.transform.localScale += new Vector3(0.01f, 0.01f, 0);
                }

                else
                {

                }

            }

            if (pc.Dead != true)
            {
                transform.Translate(pc.ForSpeed, 0, 0, Space.World);
            }
            
        }


    }

    public void LoadThis()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
