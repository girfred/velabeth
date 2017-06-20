using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour {
	private Rigidbody2D spike;
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Maga");;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnTriggerEnter2D(Collider2D col){
		SceneManager.LoadScene("TelaDerrota");
	}
}
