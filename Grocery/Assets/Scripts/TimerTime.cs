﻿using UnityEngine;
using System.Collections;

public class TimerTime : MonoBehaviour {
	public float Seconds = 59;
	public float Minutes = 0;
	bool start = false;

	void Update () 
	{
		if (Input.GetKeyDown ("d")){
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
	}

