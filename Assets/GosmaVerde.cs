using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GosmaVerde : MonoBehaviour {

	public float velocidade;
	public bool direcao;
	public float duracaoDirecao;
	public float vel,tempo;
	public Bounds bounds;
	public GameObject maga;
	public int vidas;
	public bool dano;

	private float tempoNaDirecao;
	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		vel = velocidade;
		tempo = Time.deltaTime;
		dano = animator.GetBool ("dano");
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
		/*if (dano) {
			animator.SetBool("dano", true);
		} else {
			animator.SetBool("dano", false);
		}*/
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
		{
			animator.SetBool ("dano", true);
			//animator.SetBool("atacar", true);
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
}
