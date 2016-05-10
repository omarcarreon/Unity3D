//#pragma strict

function OnCollisionEnter(col : Collision){
	if(col.gameObject.name == "Cube"){
		Destroy(col.gameObject);
	}	
}