using UnityEngine;
using System.Collections;

public class CharacterDance : MonoBehaviour {

	private string SelectedCharacter;
	private float change = 400;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.name == SelectedCharacter) {
			this.transform.Rotate (0, 1, 0);
		}

		if (change <= 0) {
			Application.LoadLevel("Result");
		}
		change--;
	}

	void Awake () {
		SelectedCharacter = PlayerPrefs.GetString("CharacterName");
	}
}
