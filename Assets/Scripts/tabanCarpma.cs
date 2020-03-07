using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabanCarpma : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag== "top" || coll.gameObject.tag== "kotuTop" || coll.gameObject.tag=="shanks" || coll.gameObject.tag=="ace") 
		{	
			Destroy (coll.gameObject);
		}


	}
}
