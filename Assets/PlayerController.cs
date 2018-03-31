using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	void Start () {
	}

	public void LButtonDown(){
		if (transform.position.x < -6.0f) {return;}
		transform.Translate (-1, 0, 0);
	}

}