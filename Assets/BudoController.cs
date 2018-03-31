using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BudoController : MonoBehaviour {

	GameObject shingen;

	void Start () {
		this.shingen = GameObject.Find ("shingen");
	}


	void Update(){
		transform.Translate (0, -0.1f, 0);
		if (transform.position.y < -5.0f) {
			Destroy (gameObject);
		}
		Vector2 p1 = transform.position;
		Vector2 p2 = this.shingen.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.1f;
		float r2 = 0.7f;

		if (d < r1 + r2) {	Destroy (gameObject);
			
		}

	
	}	
}