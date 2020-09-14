using UnityEngine;
using System.Collections;

public class OtherScreenMove : MonoBehaviour {
	public GameObject character;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (character.transform.position.x-83, 0.33f, character.transform.position.z);
	}
}
