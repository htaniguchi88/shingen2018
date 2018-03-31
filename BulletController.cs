using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public GameObject explosionPrefab;//爆発

	void Update () {
		transform.Translate (0, 0.18f, 0);

		if (transform.position.y > 5) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		GameObject.Find ("Canvas").GetComponent<UIController> ().AddScore (); //スコア更新

		GameObject effect = Instantiate (explosionPrefab, transform.position, Quaternion.identity)as GameObject;
		Destroy (effect, 1.0f);

		Destroy (coll.gameObject);
		Destroy (gameObject);
	}
}
