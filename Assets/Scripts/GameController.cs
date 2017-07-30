using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Slider Fuelbar;
    public Slider PowerupTimeSlider;
    public Text scoreTxt;
    public Image pwrUpImg;
    public Sprite dubPointsImg, turboFuelImg, strengthImg, blankImg;

    public float score;
    public bool PowerUp = false;
    public float StartPowerUpTime;
    public float EndPowerUpTime;
    public bool DoubleScore = false;
    public bool TurboFuel = false;
    public bool Strength = false;
    
    public float PowerUpTime = 8;

    public float time;

    public bool pause = false;

    PlayerController pc;

    MatChange mc;


    // Use this for initialization

    


    void Awake()
    {
        Application.targetFrameRate = 60;
    }

    void Start () {

        pc = GameObject.Find("Player").GetComponent<PlayerController>();

        mc = GameObject.Find("Car1").GetComponent<MatChange>();

    }
	
	// Update is called once per frame
	void Update () {
        
        
        if(pause != true)
        {
            time += Time.deltaTime;

            pc.ForSpeed = Mathf.Clamp(time / 50, 0.5f, 1.5f);

            if(Fuelbar.value == 0)
            {
                pc.Dead = true;
            }

            if (pc.Dead == false)
            {
                score += Mathf.Round(Time.deltaTime * 50);
                scoreTxt.text = "Score: " + score;
            }
            
            

            if (PowerUp)
            {

                if (DoubleScore)
                {
                    score += Mathf.Round(Time.deltaTime * 50);
                }

                PowerupTimeSlider.value -= Time.deltaTime / 8;

                if (PowerupTimeSlider.value == 0)
                {
                    PowerUp = false;
                    DoubleScore = false;
                    TurboFuel = false;
                    Strength = false;

                    pwrUpImg.sprite = blankImg;

                    mc.ToNorm();

                    EndPowerUpTime = 0;
                }

            }

            if (TurboFuel == false)
            {
                Fuelbar.value -= Time.deltaTime / 15;
            }
            
            
        }

    

	}
    
    public void SetPowerUpTimes()
    {
        EndPowerUpTime += Time.time + PowerUpTime;
        PowerupTimeSlider.value = 1;


    }

    public void FuelUp()
    {
        Fuelbar.value = 1;
    }

    public void PauseCheck( )
    {
        if (!pause)
        {
            pause = true;
            return;
        }


        if (pause)
        {
            pause = false;
            return;
        }

        

        
    }
    
}
