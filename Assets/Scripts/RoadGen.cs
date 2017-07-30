using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGen : MonoBehaviour {

    public GameObject road1, road2;

    public GameObject bar;

    public int temp;


	// Use this for initialization
	void Start () {

        GenerateRoad(0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateRoad(int num)
    {
        GameObject TParent = new GameObject();

        for (int i = 0 ; i < 25; i++)
        {
            int rand = Random.Range(0, 3);


            if (rand == 0)
            {
                Instantiate(road1, new Vector3(num  +  (i * 8), 0, 0), Quaternion.identity, TParent.transform);
            }

            if (rand != 0)
            {
                Instantiate(road2, new Vector3(num  + (i * 8), 0, 0), Quaternion.identity, TParent.transform);
            }

            temp = i;
        }

        TParent.name = "road" + num;

        Instantiate(bar, new Vector3(num + 100, 0, 0), Quaternion.identity);
    }


}
