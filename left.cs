﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left : MonoBehaviour {

	GameObject shingen;
	bool now = false;

	void Start () {
		this.shingen = GameObject.Find ("shingen");
	}

	void Update () {
		if (now == true) {
			Vector3 Qpos = shingen.transform.localPosition;
			Qpos.x -= (5.0f * Time.deltaTime);
			if (Qpos.x < -7.0f) {Qpos.x = -7.0f;}
			shingen.transform.localPosition = Qpos;
		}
	}
	public void OnLD(){
		now = true;
	}

	public void OnLU(){
		now = false;
	}
}
