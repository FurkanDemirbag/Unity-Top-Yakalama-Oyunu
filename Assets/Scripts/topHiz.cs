using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topHiz : MonoBehaviour {
	Rigidbody2D rg;
	public float hiz;
	// Use this for initialization
	void Start () {
		rg = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rg.velocity = new Vector2 (0, -1) * Time.deltaTime * hiz;
	}
}
