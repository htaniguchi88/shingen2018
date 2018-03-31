using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletButtonController : MonoBehaviour {

	public GameObject shingen;
	public GameObject bulletPrefab;

	void Start () {
		this.shingen = GameObject.Find ("shingen");
	}

	public void BulletButtonDown(){
		Instantiate (bulletPrefab, transform.position, Quaternion.identity);
	}


}
