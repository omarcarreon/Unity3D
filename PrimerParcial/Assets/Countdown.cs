using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour {

	public Text time;
	public static float timeLeft;
	// Use this for initialization
	void Start () {
		timeLeft = 60;
		time.text = "Tiempo: "+ timeLeft;
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		time.text = "Tiempo: "+ (int)timeLeft;
			if ( timeLeft < 0 )
			{
				Application.LoadLevel ("GameOverPerder");
			}
	}
}
