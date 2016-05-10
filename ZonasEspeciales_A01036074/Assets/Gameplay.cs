using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gameplay : MonoBehaviour {
	public Text txtVida;
	public Text txtScore;
	public int vida;
	public int score;
	public Rigidbody esferaPrefab;

	// Use this for initialization
	void Start () {
		vida = 100;
		score = 0;
		txtVida.text = "Vida: " + vida;
		txtScore.text = "Score: " + score;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.name == "ZonaRecargaVida"){
			vida += 50;
			txtVida.text = "Vida: " + vida;
		}

		if(col.gameObject.name == "ZonaCreaEsferas"){
			Instantiate(esferaPrefab, new Vector3(Random.Range (-4, 5), 4, Random.Range (-4, 5)), Quaternion.identity);
			Instantiate(esferaPrefab, new Vector3(Random.Range (-4, 5), 4, Random.Range (-4, 5)), Quaternion.identity);
			Instantiate(esferaPrefab, new Vector3(Random.Range (-4, 5), 4, Random.Range (-4, 5)), Quaternion.identity);
			Instantiate(esferaPrefab, new Vector3(Random.Range (-4, 5), 4, Random.Range (-4, 5)), Quaternion.identity);
		}


	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == "Sphere(Clone)"){
			Destroy(collision.gameObject);
			int opcion = Random.Range(1, 3);

			if(opcion == 1){
				score+= 100;
				txtScore.text = "Score: " + score;
			}
			else{
				vida -= 10;
				txtVida.text = "Vida: " + vida;
			}

			if (score >= 1000) {
				Application.LoadLevel("Ganar");
			}
			if (vida <= 0) {
				Application.LoadLevel("Perder");
			}

		}
	}
}
