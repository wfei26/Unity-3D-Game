﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyS2 : ItemS2 {
	public override void OnTriggerEnter (Collider other)
	{
		base.OnTriggerEnter (other);
		if (other.tag == "Player") {
			PlayerControllerS2.instance.Multiply ();
		}
	}
}
