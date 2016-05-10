import UnityEngine.UI;
public var x = 0;
public var y = 0;
public var z = 0;

function Update () {
	if (Input.GetKey(KeyCode.UpArrow)){
		x++;
		this.transform.eulerAngles =  Vector3(x,0,z);
	}
	if (Input.GetKey (KeyCode.DownArrow)){
		x--;
		this.transform.eulerAngles =  Vector3(x,0,z);
	}
	if (Input.GetKey(KeyCode.LeftArrow)){
		z++;
		this.transform.eulerAngles =  Vector3(x,0,z);
	}
	if (Input.GetKey (KeyCode.RightArrow)){
		z--;
		this.transform.eulerAngles =  Vector3(x,0,z);
	}
		 
}