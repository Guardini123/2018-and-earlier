using UnityEngine;
using System.Collections;

public class Script_simple : MonoBehaviour {
	public GameObject menu;
	public GameObject scripts;

	// Use this for initialization
	void Start () {
		menu.SetActive (true);
		scripts.GetComponent<stop_time>().enabled = true;
		scripts.GetComponent<run_time> ().enabled = false;
		scripts.GetComponent<cursor_viz> ().enabled = true;
		scripts.GetComponent<cirsir_not_viz> ().enabled = false;
		scripts.GetComponent<audio_off> ().enabled = true;
		scripts.GetComponent<audio_on> ().enabled = false;
		scripts.GetComponent<reset_pos_y> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			menu.SetActive (true);
			scripts.GetComponent<stop_time>().enabled = true;
			scripts.GetComponent<run_time> ().enabled = false;
			scripts.GetComponent<cursor_viz> ().enabled = true;
			scripts.GetComponent<cirsir_not_viz> ().enabled = false;
			scripts.GetComponent<audio_off> ().enabled = true;
			scripts.GetComponent<audio_on> ().enabled = false;
			scripts.GetComponent<reset_pos_y> ().enabled = false;
		}
	}
}
