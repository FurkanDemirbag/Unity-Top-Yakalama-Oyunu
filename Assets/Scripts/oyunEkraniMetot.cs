using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunEkraniMetot : MonoBehaviour {

	public GameObject butonlar;

	// Use this for initialization
	void Start () {
		//GameObject.FindGameObjectWithTag ("play").SetActive (false);
		//GameObject.FindGameObjectWithTag ("quit").SetActive (false);
		//GameObject.FindGameObjectWithTag ("bildirimMesaji").SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Cikis()
	{
		Application.Quit ();
	}

	public void Durdur()
	{
		/*GameObject.FindGameObjectWithTag ("play").SetActive (true);
		GameObject.FindGameObjectWithTag ("quit").SetActive (true);
		GameObject.FindGameObjectWithTag ("bildirimMesaji").SetActive (true);*/

		Time.timeScale = 0;
		butonlar.SetActive (true);
	}

	public void Devam()
	{
		/*GameObject.FindGameObjectWithTag ("play").SetActive (false);
		GameObject.FindGameObjectWithTag ("quit").SetActive (false);
		GameObject.FindGameObjectWithTag ("bildirimMesaji").SetActive (false);*/
		Time.timeScale = 1;
		butonlar.SetActive (false);
	}
}
