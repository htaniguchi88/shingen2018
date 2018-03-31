using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikanController : MonoBehaviour {

	GameObject shingen;
	public AudioClip mikanSE;
	AudioSource aud;


	void Start () {
		this.shingen = GameObject.Find ("shingen");
		this.aud = GetComponent<AudioSource> ();
	}
		
	
		void Update ()
	{
		transform.Translate (0, -0.05f, 0);
		if (transform.position.y < -5.0f) {	//Canvasの下端GameOver追加	
				GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver ();
				GameObject.Find ("AudioSource2").GetComponent<AudioSource> ().Play();
				
			Destroy (gameObject);
		}

		Vector2 p1 = transform.position;
		Vector2 p2 = this.shingen.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.1f;
		float r2 = 0.8f;

		if (d < r1 + r2) {Destroy (gameObject);
			GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver ();
			GameObject.Find ("AudioSource2").GetComponent<AudioSource> ().Play();
			}

		}
	}
