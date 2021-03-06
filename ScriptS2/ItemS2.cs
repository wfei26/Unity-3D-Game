﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemS2 : MonoBehaviour {
	public float rotateSpeed = 1;
	public GameObject hitEffect;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (0, rotateSpeed * Time.deltaTime, 0);
	}

	public virtual void HitItem() {
		PlayHitAudio ();
		GameObject effect = Instantiate(hitEffect);
		effect.transform.parent = PlayerControllerS2.instance.gameObject.transform;
		effect.transform.localPosition = new Vector3 (0, 0.5f, 0);
		Destroy (gameObject);
	}

	public virtual void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			//AudioManager.instance.PlayGetItemAudio ();
			HitItem ();
		}
	}

	public virtual void PlayHitAudio()
	{
		AudioManagerS2.instance.PlayGetItemAudio ();
	}
}
