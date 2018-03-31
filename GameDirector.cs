using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIを使うので忘れずに追加

public class GameDirector : MonoBehaviour {

	GameObject hpGauge;
	public AudioClip mikanSE;
	AudioSource aud;

	void Start()  {
		this.hpGauge = GameObject.Find ("hpGauge");
		this.aud = GetComponent<AudioSource> ();
		if (this.gameObject.tag == "Mikan") {
			Debug.Log ("Tag=Mikan");
		}
	}


	public void DecreaseHp() {
		this.hpGauge.GetComponent<Image> ().fillAmount -= 0.1f;
		this.aud.PlayOneShot (this.mikanSE);
	}

}

