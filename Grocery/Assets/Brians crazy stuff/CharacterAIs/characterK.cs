﻿using UnityEngine;
using System.Collections;

//x = 2.368642
//z = 3.32268

public class characterK : MonoBehaviour {
	float x = 1f;
	float y = 0f;
	float z = 0f;
	float speed = 1/35f;
	int counter = 0;
	int counterCheck = 200;
	int state = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (x, y, z) * speed;
		if (counter == counterCheck) {
			counter = 0;
			state++;
			
		}
		
		if (state == 0) {
			x = 0;
			y = 0;
			z = 1;
			counterCheck = 150;
		} else if (state == 1) {
			x = 0;
			y = 0;
			z = 0;
			counterCheck = 200;
			
		} else if (state == 2) {
			x = 0;
			y = 0;
			z = 1;
			counterCheck = 300;
			
		} else if (state == 3) {
			x = 0;
			y = 0;
			z = 0;
			counterCheck = 250;
		} else if (state == 4) {
			x = 0;
			y = 0;
			z = -1;
			counterCheck = 225;
		} else if (state == 5) {
			x = 0;
			y = 0;
			z = 0;
			counterCheck = 200;
		} else if (state == 6) {
			x = 0;
			y = 0;
			z = -1;
			counterCheck = 225;
		}
		else if (state == 7) {
			state = 0;
			
			
		}
		
		
		counter++;
	}
}
