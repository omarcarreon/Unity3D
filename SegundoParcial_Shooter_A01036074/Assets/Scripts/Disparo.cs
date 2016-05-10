using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {
	public Rigidbody humo;
	public int speed = 100;
	Rigidbody clone;
	public AudioSource humoSound;

	// Use this for initialization
	void Start () {
		 humoSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButton("Fire1")) {
			clone = Instantiate(humo, transform.position, transform.rotation) as Rigidbody;
			
			clone.velocity = transform.TransformDirection(new Vector3 (0,0,speed));

			Destroy(clone.gameObject, 1);
		}

		if(GameObject.Find("Humo(Clone)") == null) {
			humoSound.loop = true;
			humoSound.Play();
		}
	}
}
