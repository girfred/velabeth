using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velho : MonoBehaviour {

    Animator anim;
    float velocidade = 4;
	public Rigidbody2D rb;
	bool pulando;
	

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		pulando = false;
    }

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "chao")
			pulando = false;
		

	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis ("Horizontal");
        float pulo = Input.GetAxis ("Vertical");
        
        if(move != 0) {
            
                if(move > 0) {
                     transform.Translate(Vector2.right * velocidade * Time.deltaTime);
                    if(transform.localScale.x < 0)
                        transform.localScale = new Vector3((-1) * transform.localScale.x, transform.localScale.y, transform.localScale.z);
                } else {
                     transform.Translate((-1) * Vector2.right * velocidade * Time.deltaTime);
                    if(transform.localScale.x > 0)
                        transform.localScale = new Vector3((-1) * transform.localScale.x, transform.localScale.y, transform.localScale.z);
                }
            
              anim.SetInteger("andar", 1); 
        } else
            anim.SetInteger("andar", 0); 
        
		if(pulando == false && pulo>0) {
          	rb.AddForce(transform.up * 500);
			pulando = true;
       }


    }

}
