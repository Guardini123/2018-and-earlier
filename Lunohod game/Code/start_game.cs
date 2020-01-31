using UnityEngine;
using System.Collections;

public class start_game : MonoBehaviour {
	public float tamer;
	int i = 0;
	public bool can_play;
	public GameObject car;
	public GameObject welcoms;
	public GameObject scripts;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		//AudioListener.pause = true;
		if (tamer > 0)
			tamer -= Time.deltaTime;
		if (tamer < 0)
			can_play = true; 
		if (can_play) {
			welcoms.SetActive (false);
			//AudioListener.pause = false;
			scripts.SetActive (true);
			car.SetActive (true);
		}
	}
}
