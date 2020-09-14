using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
	public GameObject character;
	//bool decide = false;
	bool choose = false;
	Vector3 prePos;
	Vector3 currPos;
	Vector3 tile;
	public Camera cam;
	public GameObject block1;
	public GameObject block2;
	public GameObject block3;
	public GameObject block4;
	public Renderer rend;
	void Start () {
		//character.AddComponent<Animation> ();
		tile = character.transform.position;
		currPos = character.transform.position;
	}
	void Update () {
		if (choose) {
			if (character.transform.position != tile) {
				Vector3 move = Vector3.MoveTowards (character.transform.position, tile, 0.8f * Time.deltaTime) - character.transform.position;
				character.transform.position = Vector3.MoveTowards (character.transform.position, tile, 0.8f * Time.deltaTime);
				cam.transform.position += new Vector3 (move.x, 0, move.z);
				block1.transform.position += new Vector3 (move.x, 0, move.z);
				block2.transform.position += new Vector3 (move.x, 0, move.z);
				block3.transform.position += new Vector3 (move.x, 0, move.z);
				block4.transform.position += new Vector3 (move.x, 0, move.z);
				rend.enabled = false;
				choose = true;
			} else 
				choose = false;
		}
		prePos = currPos;
		currPos = character.transform.position;
		//print (choose);
	}
	void OnMouseOver(){
		if(prePos == currPos)
			rend.enabled = true;
	}
	void OnMouseExit(){
		rend.enabled = false;
	}
	void OnMouseDown() {
		if (Input.GetMouseButtonDown (0) &&	prePos == currPos) {
			if (!choose) {
				character.transform.LookAt (this.transform.position);
				character.transform.Rotate (new Vector3 (0, -90, 0));
				tile = this.transform.position;
				choose = true;
				character.GetComponent<Animation> () ["Walk2"].speed = 2;
				character.GetComponent<Animation> ().Play ();
				character.GetComponent<Animation> ().PlayQueued ("Walk2").speed = 2;
			}
		}
	}
}