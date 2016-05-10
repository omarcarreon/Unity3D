using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text txt;
    public Text greentxt;
    public Text whitetxt;
    public Text redtxt;
	public static int crash;
    public static int green;
    public static int white;
    public static int red;
    public Material newMaterialRef;
	// Use this for initialization
	void Start () {
		txt.text = "Score: 0 ";
		crash = 0;
        green = 0;
        white = 0;
        red = 0;
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Score: " + crash;
        greentxt.text = "Verdes: " + green + "/3";
        whitetxt.text = "Blancas: " + white + "/3";
        redtxt.text = "Rojas: " + red + "/3";
        if (crash == 9){
            Application.LoadLevel("GameOverGanar");
        }
        if (green == 3)
        {
            GameObject.Find("FlagGreen").GetComponent<Renderer>().material.color = Color.green;    
        }
        if (white == 3)
        {
            GameObject.Find("FlagWhite").GetComponent<Renderer>().material.color = Color.white;
        }
        if (red == 3)
        {
            GameObject.Find("FlagRed").GetComponent<Renderer>().material.color = Color.red;
        }
	}
}
