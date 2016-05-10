using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gameplay : MonoBehaviour {

	public Text txtFuego;
	public static int fuego;
	public Text txtTiempo;
	public float tiempo;
	// Use this for initialization
	void Start () {
		fuego = 100;
		tiempo = 120;
		txtFuego.text = "Fuego: " + fuego + "%";
		txtTiempo.text = "Tiempo:" + tiempo;
	}
	
	// Update is called once per frame
	void Update () {
		txtFuego.text="Fuego: " + fuego + "%";
		tiempo -= Time.deltaTime;
		txtTiempo.text = "Tiempo: "+ (int)tiempo;
		if (tiempo < 0) {
			Application.LoadLevel ("GameOverPerder");
		}
		if (fuego == 0) {
			Application.LoadLevel("GameOverGanar");
		}

	}
}
