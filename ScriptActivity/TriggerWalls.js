#pragma strict
import UnityEngine.UI;

//variables 
var txt: UI.Text;
static var crash : int;


function Start () {
	txt.text = "Collisions: ";
	crash = 0;

}

function OnTriggerEnter(col : Collider){
	if(col.gameObject.name == "Ethan"){
		crash++;
		txt.text="Collitions: "+crash;
	}
}