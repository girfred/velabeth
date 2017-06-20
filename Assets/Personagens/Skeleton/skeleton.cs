using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeleton : MonoBehaviour {

	public float velocidade;
	public bool direcao;
	public float duracaoDirecao;
    public float vel,tempo;

	private float tempoNaDirecao;
	private Animator animator; 

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
        vel = velocidade;
		tempo = Time.deltaTime;
	}

	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player")
        {
            animator.SetBool("atacar", true);
            velocidade = velocidade-velocidade;
            tempo = 0;
        }
	}

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            animator.SetBool("atacar", false);
            velocidade = vel;
            tempo = Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update () {
		if (direcao) {
			transform.eulerAngles = new Vector2(0, 0);
		} else {
			transform.eulerAngles = new Vector2(0, 180);
		}
		transform.Translate(Vector2.right * velocidade * tempo);

		tempoNaDirecao += tempo;
		if (tempoNaDirecao >= duracaoDirecao) {
			tempoNaDirecao = 0;
			direcao = !direcao;
		}
	}
	
	/*void OnCollisionEnter2D(Collision2D colisor) {
		if (colisor.gameObject.tag == "Player") {
			animator.SetTrigger("atacou");
			var player = colisor.gameObject.transform.GetComponent();
	
			player.PerdeVida(30);
			colisor.gameObject.transform.Translate(-Vector2.right);
		}
	}*/
}
