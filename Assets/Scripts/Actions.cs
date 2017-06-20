using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Actions : MonoBehaviour {

	private Animator animator;

    public AudioClip spinSound;
    private AudioSource audioS;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
        audioS = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			animator.SetBool("attack", true);
            audioS.clip = spinSound;
            audioS.Play();
		} else {
			animator.SetBool("attack", false);
		}
		if (Input.GetButtonDown ("Reset")) { 
			SceneManager.LoadScene("scene");
		}
	}
}
