using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatChange : MonoBehaviour {

    public Material StrengthMat;
    public Material NormalMat;
    public Material NormalCoversMat;

    public Material[] mats;

    // Use this for initialization
    void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToStrength() {
        mats = GetComponent<Renderer>().materials;
        mats[3] = StrengthMat;
        mats[4] = StrengthMat;
        mats[6] = StrengthMat;
        GetComponent<Renderer>().materials = mats;
        
    }

    public void ToNorm()
    {
        mats = GetComponent<Renderer>().materials;
        mats[3] = NormalMat;
        mats[4] = NormalCoversMat;
        mats[6] = NormalCoversMat;
        GetComponent<Renderer>().materials = mats;
    }
}
