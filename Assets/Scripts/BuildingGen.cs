using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGen : MonoBehaviour
{

    public GameObject building1, building2, building3, building4, building5, building6;


    // Use this for initialization
    void Start()
    {
        GenerateBuildings(0);

    }

    // Update is called once per frame
    void Update()
    {



    }

    public void GenerateBuildings(int num)
    {

        GameObject TParent = new GameObject();

        for (int i = 0; i < 25; i++)
        {
            int rand = Random.Range(0, 8);

            if (rand == 0)
            {
                Instantiate(building1, new Vector3(num + (i * 8), 0, -10.2f), Quaternion.Euler(0, 90, 0), TParent.transform);
            }

            if (rand == 1)
            {
                Instantiate(building2, new Vector3(num + (i * 8), 0, -10.2f), Quaternion.Euler(0, 90, 0), TParent.transform);
            }

            if (rand == 2)
            {
                Instantiate(building3, new Vector3(num + (i * 8), 0, -10.2f), Quaternion.Euler(0, 90, 0), TParent.transform);
            }

            if (rand == 3)
            {
                Instantiate(building4, new Vector3(num + (i * 8), 0, -10.2f), Quaternion.Euler(0, 90, 0), TParent.transform);
            }

            if (rand == 4)
            {
                Instantiate(building5, new Vector3(num + (i * 8), 0, -10.2f), Quaternion.Euler(0, 90, 0), TParent.transform);
            }

            if (rand == 5)
            {
                Instantiate(building6, new Vector3(num + (i * 8), 0, -10.2f), Quaternion.Euler(0, 90, 0), TParent.transform);
            }
        }


        for (int i = 0; i < 25; i++)
        {
            int rand = Random.Range(0, 8);
            

            if (rand == 0)
            {
                Instantiate(building1, new Vector3(num + (i * 8), 0, 10.2f), Quaternion.Euler(0, -90, 0), TParent.transform);
            }

            if (rand == 1)
            {
                Instantiate(building2, new Vector3(num + (i * 8), 0, 10.2f), Quaternion.Euler(0, -90, 0), TParent.transform);
            }

            if (rand == 2)
            {
                Instantiate(building3, new Vector3(num + (i * 8), 0, 10.2f), Quaternion.Euler(0, -90, 0), TParent.transform);
            }

            if (rand == 3)
            {
                Instantiate(building4, new Vector3(num + (i * 8), 0, 10.2f), Quaternion.Euler(0, -90, 0), TParent.transform);
            }

            if (rand == 4)
            {
                Instantiate(building5, new Vector3(num + (i * 8), 0, 10.2f), Quaternion.Euler(0, -90, 0), TParent.transform);
            }

            if (rand == 5)
            {
                Instantiate(building6, new Vector3(num + (i * 8), 0, 10.2f), Quaternion.Euler(0, -90, 0), TParent.transform);
            }
        }

        TParent.name = "buildings" + num;

    }
}
