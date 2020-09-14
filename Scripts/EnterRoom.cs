using UnityEngine;
using System.Collections;

public class EnterRoom : MonoBehaviour {
	public Renderer rend;
	public Vector3 move;
	public GameObject character;
	public Camera cam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseOver(){
		if (Vector3.Distance (character.transform.position, this.transform.position) < 2) {
			rend.enabled = true;
		}
	}
	void OnMouseExit(){
		rend.enabled = false;
	}
	void OnMouseDown(){
		if (Vector3.Distance (character.transform.position, this.transform.position) < 2) {
			Vector3 move2 = character.transform.position - move;
			character.transform.position = move;
			character.transform.eulerAngles = new Vector3 (0, 270, 0);
			cam.transform.position = new Vector3 (cam.transform.position.x-move2.x, 4f, cam.transform.position.z-move2.z);
			cam.transform.LookAt (character.transform.position);
		}
	}
}
