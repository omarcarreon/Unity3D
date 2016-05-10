function OnCollisionEnter(col: Collision){
	if(col.gameObject.name == "Wall"){
		Wall.crash++;
	}
}