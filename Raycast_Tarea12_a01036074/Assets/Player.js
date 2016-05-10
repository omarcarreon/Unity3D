#pragma strict 
function Start () { 
}
function Update () {
	var hit : RaycastHit;
	var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	Debug.DrawRay(ray.origin, ray.direction*10, Color.red);
	if (Physics.Raycast(ray,hit)){
		if (hit.transform.name == "Lumberjack1" || hit.transform.name == "Lumberjack2" || hit.transform.name == "Lumberjack3"){
			Destroy(hit.transform.gameObject); 
		}

		print("I see a: "+ hit.transform.name+", and is"+hit.distance+"units apart");
	} else{
		print("I see nothing, nothing.");
	}
} 