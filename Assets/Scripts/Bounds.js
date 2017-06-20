#pragma strict

function Start () {
	
}

function Update () {
	// X axis
 if (transform.position.x <= -11.28f) {
     transform.position = new Vector2(-11.28f, transform.position.y);
 } else if (transform.position.x >= 164f) {
     transform.position = new Vector2(164f, transform.position.y);
 }
 
 // Y axis
 if (transform.position.y <= -11f) {
     transform.position = new Vector2(transform.position.x, -11f);
 } else if (transform.position.y >= 11f) {
     transform.position = new Vector2(transform.position.x, 11f);
 }
}
