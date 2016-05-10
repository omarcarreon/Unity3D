#pragma strict
import UnityEngine.UI;

function CargaEscena(nombre : String){
	Application.LoadLevel(nombre);
}

function Salir(){
	Application.Quit();
}