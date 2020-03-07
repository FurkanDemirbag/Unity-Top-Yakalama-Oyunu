using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesAcKapa : MonoBehaviour {

	private AudioSource sesDosyasi;
	private float muzikSesi = 1f;
	// Use this for initialization
	void Start () {
		sesDosyasi = this.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		sesDosyasi.volume = muzikSesi;
	}

	public void sesAyarla(float vol)
	{
		muzikSesi = vol;
	}
}
