using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girisEkraniMetot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Cikis()
	{
		Application.Quit ();
	}

	public void Baslat()
	{
		Application.LoadLevel ("oyunEkrani");
	}
}
