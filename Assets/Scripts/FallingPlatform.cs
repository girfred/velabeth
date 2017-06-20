using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {
    public float fallTime = 2;
    private Rigidbody2D platform;

    void Start(){
        platform = GetComponent<Rigidbody2D>();
    }

    IEnumerator platformShake(float fallTime){
        while(fallTime > 0){
            platform.position = new Vector2(platform.position.x + (Random.insideUnitCircle.x * 0.05f), platform.position.y);
            yield return new WaitForSeconds(0.0001f);
            fallTime -= Time.deltaTime;
        }
		platform.isKinematic = false;
		DestroyPlat ();
    }

    void OnTriggerEnter2D(Collider2D col){
        StartCoroutine(platformShake(fallTime));
    }

	void DestroyPlat(){
		Destroy (this.gameObject, 1.5f);
	}
}
