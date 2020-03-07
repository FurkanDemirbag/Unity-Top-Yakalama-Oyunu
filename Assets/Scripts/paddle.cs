using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class paddle : MonoBehaviour {

	public float arttir = 0;
	public int saydir = 0;
	public Text skor;

	public int can = 3;

	public AudioClip iyiSes;
	public AudioClip kotuSes;

	public bool gameOver=false;

	public Text highScore;
	public GameObject highhScore;

	public GameObject patlama;

	public GameObject can1;
	public GameObject can2;
	public GameObject can3;
	public GameObject bosCan1;
	public GameObject bosCan2;
	public GameObject bosCan3;


	void Start () 
	{
		gameOver = false;

		highScore.text = PlayerPrefs.GetInt ("HighScore", 0).ToString ();
	}

	void Update () {

		Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector3 kendiPos = new Vector3 (transform.position.x, transform.position.y,0);

		transform.position = Vector3.MoveTowards (kendiPos, new Vector3 (mousePosition.x, transform.position.y, 0),
																		 Time.deltaTime * arttir);

		var pos = transform.position;
		pos.x = Mathf.Clamp (pos.x, -1.9f, 1.9f);
		transform.position = pos;


		if (Input.GetMouseButtonDown (0) && gameOver)
		{
			Time.timeScale = 1;
			Scene scene = SceneManager.GetActiveScene ();
			SceneManager.LoadScene (scene.name);
		}

		if (saydir > PlayerPrefs.GetInt ("HighScore", 0)) 
		{
			int higScore = saydir;
			PlayerPrefs.SetInt ("HighScore", higScore);
			highScore.text =higScore.ToString ();
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag== "top") 
		{	
			saydir++;
			skor.text = "Skor : " + saydir.ToString ();
			Destroy (coll.gameObject);
			AudioSource.PlayClipAtPoint (iyiSes, coll.transform.position);

			var pat =Instantiate (patlama, coll.gameObject.transform.position, Quaternion.identity);
			Destroy (pat,2);
		}

		if (coll.gameObject.tag== "shanks") 
		{	
			saydir=saydir+10;
			skor.text = "Skor : " + saydir.ToString ();
			Destroy (coll.gameObject);
			AudioSource.PlayClipAtPoint (iyiSes, coll.transform.position);

			var pat =Instantiate (patlama, coll.gameObject.transform.position, Quaternion.identity);
			Destroy (pat,2);
		}

		if (coll.gameObject.tag== "ace") 
		{	
			saydir=saydir+5;
			skor.text = "Skor : " + saydir.ToString ();
			Destroy (coll.gameObject);
			AudioSource.PlayClipAtPoint (iyiSes, coll.transform.position);

			var pat =Instantiate (patlama, coll.gameObject.transform.position, Quaternion.identity);
			Destroy (pat,2);
		}

		if (coll.gameObject.tag == "kotuTop") 
		{
			skor.text = "Skor : " + saydir.ToString ();
			Destroy (coll.gameObject);
			can--;
			AudioSource.PlayClipAtPoint (kotuSes, coll.transform.position);
		}

		if (can == 0) 
		{
			gameOver = true;
			Time.timeScale = 0;
			skor.text = "Game Over !" +
				" Skorun : " + saydir.ToString ();

			highhScore.SetActive (true);
		}

		if (can == 2) 
		{
			can1.SetActive (true);
			can2.SetActive (true);
			can3.SetActive (false);
			bosCan3.SetActive (true);
		} 
		else if (can == 1) 
		{
			can1.SetActive (true);
			can2.SetActive (false);
			can3.SetActive (false);
			bosCan3.SetActive (true);
			bosCan2.SetActive (true);
		} 
		else if (can == 0) 
		{
			can1.SetActive (false);
			can2.SetActive (false);
			can3.SetActive (false);
			bosCan3.SetActive (true);
			bosCan2.SetActive (true);
			bosCan1.SetActive (true);
		}
	}
}
