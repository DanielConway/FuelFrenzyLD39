using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public float SideSpeed;
    public float ForSpeed;

    public ParticleSystem ps;

    public bool Dead = false;
    Rigidbody rb;

    GameController gc;
    AudioManager am;
    MatChange mc;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        gc = GameObject.Find("Scripts").GetComponent<GameController>();
        am = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        mc = GameObject.Find("Car1").GetComponent<MatChange>();
        
    }
	
	// Update is called once per frame
	void Update () {

        if(gc.pause != true)
        {
            if (transform.position.z >= 14 || transform.position.z <= -14)
            {
                Dead = true;
            }


            if (Dead != true)
            {
                float inputValHoriz = -Input.GetAxis("Horizontal") * SideSpeed;

                transform.Translate(ForSpeed, 0, inputValHoriz);
            }


            if (gc.Strength)
            {
                this.transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(.75f, .75f, .75f), Time.deltaTime);

            }

            if (!gc.Strength)
            {
                this.transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(.5f, .5f, .5f), Time.deltaTime);

            }

            
        }
        
        

    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Obstacle")
        {

            if (gc.Strength == false)
            {
                //Death(gc.score);

                ps.Play();
                am.death.Play();
                gc.PowerUp = false;
                Dead = true;
                
            }
            
        }

        if (col.tag == "Building")
        {
            //Death(gc.score);
            ps.Play();
            am.death.Play();
            gc.PowerUp = false;
            Dead = true;
        }

        if (col.tag == "Fuel")
        {

            am.fuel.Play();

            
            gc.FuelUp();

            Destroy(col.gameObject);
        }

        if (col.tag == "PowerUp")
        {


            if (gc.PowerUp == false)
            {
                gc.PowerUp = true;
                gc.SetPowerUpTimes();

                //if (col.name == "DoubleScore")
                if (col.name.Substring(0, 3) == "Dou")
                {
                    am.doubleScore.Play();
                    gc.DoubleScore = true;

                    gc.pwrUpImg.sprite = gc.dubPointsImg;

                    Destroy(col.gameObject);
                }

                if (col.name.Substring(0, 3) == "Tur")
                {
                    am.turboFuel.Play();

                    gc.FuelUp();
                    gc.TurboFuel = true;

                    gc.pwrUpImg.sprite = gc.turboFuelImg;

                    Destroy(col.gameObject);
                }

                if (col.name.Substring(0, 3) == "Str")
                {
                    am.strength.Play();

                    mc.ToStrength();
                    
                    gc.Strength = true;

                    gc.pwrUpImg.sprite = gc.strengthImg;

                    Destroy(col.gameObject);
                }
            }
            
        }
    }

    void Death(int RunScore)
    {

    }

    void SizeUp()
    {
        
    }
}
