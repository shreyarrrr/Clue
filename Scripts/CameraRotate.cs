using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour {
	public GameObject character;
	void Start () {
	
	}
	void Update () {
		if (Input.GetKey ("right"))
			this.transform.RotateAround (character.transform.position, new Vector3 (0, 2, 0), 1);
		if (Input.GetKey ("left"))
			this.transform.RotateAround (character.transform.position, new Vector3 (0, 2, 0), -1);
		if(this.transform.rotation.eulerAngles.x < 25) {
			if (Input.GetKey ("up")) {	
				this.transform.Rotate (new Vector3 (1, 0, 0));
				this.transform.position += new Vector3 (0, 0.05f,0);
			}
		}
		if (this.transform.rotation.eulerAngles.x > 5) {		
			if (Input.GetKey ("down")) {
				this.transform.Rotate (new Vector3 (-1, 0, 0));
				this.transform.position += new Vector3 (0, -0.05f, 0);
			}
		}
	}
	void OnCollisionEnter(Collision enter){
		if (Input.GetKey ("right"))
			this.transform.RotateAround (character.transform.position, new Vector3 (0, 2, 0), -1);
		if (Input.GetKey ("left"))
			this.transform.RotateAround (character.transform.position, new Vector3 (0, 2, 0), 1);
		
	}
}
