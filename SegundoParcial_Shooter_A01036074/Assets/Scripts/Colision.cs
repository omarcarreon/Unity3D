using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Fuego" || col.gameObject.name == "Fuego2")
		{
			Gameplay.fuego -= 10;
			Destroy(col.gameObject);
		}
	}
}
