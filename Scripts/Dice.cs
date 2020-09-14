using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown(0)){
		this.GetComponent<Animation> ().Play ();	
		//}
		//dice.GetComponent<Animation> () ["Take 001"].speed = 2;
		//dice.GetComponent<Animation> ().PlayQueued ("Take 001").speed = 2;
		//}	

	}
	void OnMouseDown() {
		print ("in");
		this.GetComponent<Animation> ().Play ();	
	}
}