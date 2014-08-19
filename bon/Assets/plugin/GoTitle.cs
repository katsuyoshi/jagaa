using UnityEngine;
using System.Collections;

public class GoTitle : MonoBehaviour {

	private float change = 200;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (change <= 0) {
			Application.LoadLevel("title");
		}
		change--;
	}
}
