﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMov : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, 100 * Time.deltaTime, 0);
	}
}
