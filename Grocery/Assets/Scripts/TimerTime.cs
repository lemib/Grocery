﻿using UnityEngine;
using System.Collections;

public class TimerTime : MonoBehaviour {
	public Texture2D Restart;
	public Texture2D NoTime;
	public float Seconds = 59;
	public float Minutes = 0;
	bool start = false;
	bool end = false;

	void Update () 
	{


		if (Input.GetKeyDown ("d")){
			start = true;
		}
		if (Input.GetKeyDown ("right")) {
			start = true;
				}
		if (start) {//delete me
						if (Seconds <= 0) { 
								Seconds = 59;
								if (Minutes >= 1) { 
										Minutes --;
								} else {
										Minutes = 0;
										Seconds = 0;
					end = true;
										GameObject.Find ("TimerText").guiText.text = Minutes.ToString ("f0") + ":" + Seconds.ToString ("f0");

								}
						} else { 
								Seconds -= Time.deltaTime;
						}
				}//delete me
		if (Mathf.Round (Seconds) <= 9) 
		{
		     GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
		}
		else
		{
			GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
		}

	
		}
	void OnGUI(){

		if (end) {
			//if (GUI.Button (new Rect (Screen.width/2, Screen.height/2, 200, 200), "The Store has Closed!\nRestart")) {
				//Application.LoadLevel("GroceryBuild1.0");
			//}
			GUI.Label (new Rect (Screen.width/3, Screen.height/10, 800,800), NoTime); 
						GUI.Label (new Rect (Screen.width/2, (Screen.height/3), 800, 800), Restart);
			if(Input.GetMouseButtonDown (0)){
				Application.LoadLevel("GroceryBuild1.0");
				}
	}
	}

}