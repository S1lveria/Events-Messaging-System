﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerTest : MonoBehaviour 
{
	void Update()
	{
		if (Input.GetKeyDown ("q")) 
		{
			EventManager.TriggerEvent ("test");
		}
		if (Input.GetKeyDown ("o")) 
		{
			EventManager.TriggerEvent ("Spawn");
		}
		if (Input.GetKeyDown ("p")) 
		{
			EventManager.TriggerEvent ("Destroy");
		}
	}
}
