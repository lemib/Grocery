﻿using UnityEngine;
using System.Collections;

public class CheckOutScrpt : MonoBehaviour {
	public GameObject CheckOutSign;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Player") {
						CheckOutSign.SetActive (true);
				}
		}
	void OnTriggerExit(Collider c)
	{
		if (c.gameObject.tag == "Player") {
						CheckOutSign.SetActive (false);
				}
	}
}
