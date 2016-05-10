using UnityEngine;
using System.Collections;

public class Choque : MonoBehaviour {
	void OnTriggerEnter(Collider col){
        
        if (col.gameObject.name == "SphereGreen")
        {
            Score.green += 1 ;
            Score.crash += 1; ;
            Countdown.timeLeft += 100;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "SphereWhite")
        {
            Score.white += 1;
            Score.crash += 1; ;
            Countdown.timeLeft += 100;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "SphereRed")
        {
            Score.red += 1;
            Score.crash += 1; ;
            Countdown.timeLeft += 100;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "SphereBlack" || col.gameObject.name == "SphereBlue" ||
            col.gameObject.name == "SpherePurple")
        {
            Application.LoadLevel("GameOverPerder");
        }
	}
}

