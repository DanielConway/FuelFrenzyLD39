using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenPowerups : MonoBehaviour {

    public GameObject[] powerups;

    public GameObject[] obstables;

    public GameObject fuel;

    float[] points = new float[] { 6.44f, 2.8f, 0f, -2.8f, -6.44f };

	// Use this for initialization
	void Start () {

        GeneratePowerups(0);
        GenerateObstacles(0);
        GenerateFuel(0);
	}

    public void GenerateFuel(int num)
    {

        GameObject TParent = new GameObject();

        for (int i = 0; i < 25; i++)
        {
            int rand = Random.Range(0, 8);
            

            int randLat = Random.Range(0, 5);
            

            if (rand == 0)
            {
                Instantiate(fuel, new Vector3(num + (i * 8), 1, points[randLat]), Quaternion.identity, TParent.transform);
            }

        }

        TParent.name = "fuel" + num;

    }
    public void GeneratePowerups(int num)
    {
        GameObject TParent = new GameObject();

        for (int i = 0; i < 25; i++)
        {
            int rand = Random.Range(0, 12);

            int rand2 = Random.Range(0, 3);

            int randLat = Random.Range(0, 5);
            


            if (rand == 0)
            {
                Instantiate(powerups[rand2], new Vector3(num + (i * 8), 1, points[randLat]), Quaternion.identity, TParent.transform);
            }
            
        }

        TParent.name = "powerups" + num;

    }

    public void GenerateObstacles(int num)
    {

        GameObject TParent = new GameObject();

        for (int i = 0; i < 25; i++)
        {
            int rand = Random.Range(0, 3);

            int rand2 = Random.Range(0, 2);

            int randLat = Random.Range(0, 5);
            


            if (rand == 0)
            {
                Instantiate(obstables[rand2], new Vector3(num + (i * 8), 0, points[randLat]), Quaternion.identity, TParent.transform);
            }

        }

        TParent.name = "obstacles" + num;

    }

}
