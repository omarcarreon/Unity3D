using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadScene(string buttonName){
        if (buttonName == "Salir")
        {
            Application.Quit();
            
        }
        else
        {
            Application.LoadLevel(buttonName);
        }

	}
}

