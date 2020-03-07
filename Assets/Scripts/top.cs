using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour {

	public GameObject[] iyiPrefabs;
	public GameObject[] kotuPrefabs;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("iyiTopOlustur", 0.1f, 1.5f);
		InvokeRepeating ("kotuTopOlustur", 2f, 3.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void iyiTopOlustur()
	{
		float salla = Random.Range (0, iyiPrefabs.Length);
		Vector3 position = new Vector3 (Random.Range (-2.2f, 2.2f), 8, Random.Range (-10.0f, 10.0f));
		var x = Instantiate (iyiPrefabs[(int)salla], position, Quaternion.identity);
		x.GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, 1, 0);
	}

	void kotuTopOlustur()
	{
		float salla = Random.Range (0, kotuPrefabs.Length);
		Vector3 position = new Vector3 (Random.Range (-2.2f, 2.2f), 8, Random.Range (-10.0f, 10.0f));
		var x = Instantiate (kotuPrefabs[(int)salla], position, Quaternion.identity);
		x.GetComponent<Rigidbody2D> ().velocity = new Vector3 (0,1, 0);
	}
		
}
