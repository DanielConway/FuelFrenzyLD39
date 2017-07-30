using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenBarScript : MonoBehaviour {

    BuildingGen bg;
    RoadGen rg;
    GenPowerups gp;

	// Use this for initialization
	void Start () {

        bg = GameObject.Find("Scripts").GetComponent<BuildingGen>();
        rg = GameObject.Find("Scripts").GetComponent<RoadGen>();
        gp = GameObject.Find("Scripts").GetComponent<GenPowerups>();
    }

    private void OnTriggerEnter(Collider other)
    {
        bg.GenerateBuildings(Mathf.RoundToInt(this.transform.position.x) + 100);
        rg.GenerateRoad(Mathf.RoundToInt(this.transform.position.x) + 100);
        gp.GeneratePowerups(Mathf.RoundToInt(this.transform.position.x) + 100);
        gp.GenerateObstacles(Mathf.RoundToInt(this.transform.position.x) + 100);
        gp.GenerateFuel(Mathf.RoundToInt(this.transform.position.x) + 100);



        Destroy(GameObject.Find(("road" + Mathf.RoundToInt(this.transform.position.x - 300).ToString())));
        Destroy(GameObject.Find(("powerups" + Mathf.RoundToInt(this.transform.position.x - 300).ToString())));
        Destroy(GameObject.Find(("obstacles" + Mathf.RoundToInt(this.transform.position.x - 300).ToString())));
        Destroy(GameObject.Find(("buildings" + Mathf.RoundToInt(this.transform.position.x - 300).ToString())));
        Destroy(GameObject.Find(("fuel" + Mathf.RoundToInt(this.transform.position.x - 300).ToString())));


    }
}
