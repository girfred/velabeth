using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerPlatformerController : PhysicsObject {

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;
    public Text Moedas;
	public GosmaVerde gv;
	public float thrust = 500;

    private SpriteRenderer spriteRenderer;
    private Animator animator;
	private Rigidbody2D rigid;
    private int moedas;
	public int vidas;
	private bool dano;
	private bool ataque;
	private Vector2 input;
	private Color cor;

    public AudioClip jumpSound, coinSound;
    private AudioSource audioS;

    // Use this for initialization
    void Awake () 
    {
        spriteRenderer = GetComponent<SpriteRenderer> (); 
        animator = GetComponent<Animator> ();
        moedas = 0;
        SetMoedas();
		vidas = animator.GetInteger ("vidas");
        audioS = gameObject.GetComponent<AudioSource>();
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis ("Horizontal");

        if (Input.GetButtonDown ("Jump") && grounded) {
            velocity.y = jumpTakeOffSpeed;
            audioS.clip = jumpSound;
            audioS.Play();
        } else if (Input.GetButtonUp ("Jump")) {
            if (velocity.y > 0) {
                velocity.y = velocity.y * 0.5f;
            }
        }

        //bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
		if ((spriteRenderer.flipX == false && move.x < -0.01f) || (spriteRenderer.flipX == true && move.x > 0.01f)) 
        {			
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        animator.SetBool ("grounded", grounded);
        animator.SetFloat ("velocityX", Mathf.Abs (velocity.x) / maxSpeed);

        targetVelocity = move * maxSpeed;
    }

    void SetMoedas(){
        Moedas.text = "Moedas: " + moedas.ToString();
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
            audioS.clip = coinSound;
            audioS.Play();
            moedas = moedas + 1;
			SetMoedas ();
		}
		if (other.transform.tag == "Buraco") {
			SceneManager.LoadScene("TelaDerrota");
		}
		if (other.transform.tag == "Final") {
			SceneManager.LoadScene("TelaVitoria");
		}
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.transform.tag == "Enemy") {
			gv = other.gameObject.GetComponent<GosmaVerde> ();
			gv.animator.SetBool("dano", false);
			ataque = animator.GetBool ("attack");
			//animator.SetBool("hurt", true);

			if (ataque == true) {
				gv.vidas = gv.vidas - 1;
				//gv.dano = true;
				gv.animator.SetBool("dano", true);
			}			

			if ((gv.vidas == 0) && (ataque == true)) {
				Destroy (other.gameObject);
			}

			//gv.dano = false;
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.tag == "Enemy") {
			gv = other.gameObject.GetComponent<GosmaVerde> ();
			animator.SetBool("hurt", true);
			vidas = vidas - 1;

			if(spriteRenderer.flipX == true) GetComponent<Rigidbody2D> ().AddForce(new Vector2(3,2), ForceMode2D.Impulse);
			else GetComponent<Rigidbody2D> ().AddForce(new Vector2(-3,2), ForceMode2D.Impulse);

			StartCoroutine(Esperar());
			StartCoroutine (LevaDano ());

			gv.animator.SetBool("atacar", true);
			if (vidas == 0) {
				SceneManager.LoadScene("TelaDerrota");
			}
		}
	}

	void OnCollisionStay2D(Collision2D other){
		if (other.transform.tag == "MovPlat") {
			transform.parent = other.transform;
		}
	}

	void OnCollisionExit2D(Collision2D other){
		if (other.transform.tag == "MovPlat") {
			transform.parent = null;
		}
		if (other.transform.tag == "Enemy") {
			animator.SetBool("hurt", false);
		}
	}

	IEnumerator Esperar(){
		yield return new WaitForSeconds(1.5f);
		GetComponent<Rigidbody2D> ().Sleep();
	}

	IEnumerator LevaDano(){
		cor =  GetComponent<SpriteRenderer>().color;
		spriteRenderer.material.color = new Color(1f,0.30196078f, 0.30196078f);
		yield return new WaitForSeconds(1f);
		spriteRenderer.material.color = cor;
	}
}