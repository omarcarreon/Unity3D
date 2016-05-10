var Bala: Rigidbody;
var speed = 100;

function Update() {
	if(Input.GetButton("Fire1")){
		clone = Instantiate(Bala, transform.position, transform.rotation);
		clone.velocity = transform.TransformDirection(Vector3 (0,0,-speed));
		Destroy(clone.gameObject, 1);
	}
}