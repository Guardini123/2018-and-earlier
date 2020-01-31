using UnityEngine;
using System.Collections;

public class camera_change : MonoBehaviour {
	public GameObject cam_3;
	public GameObject cam_1;
	private bool is_first;
	// Use this for initialization
	void Start () {
		is_first = false;
		cam_1.SetActive (false);
		cam_3.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			if (is_first) {
				is_first = false;
				cam_3.SetActive (true);
				cam_1.SetActive (false);
			} else {
				is_first = true;
				cam_3.SetActive (false);
				cam_1.SetActive (true);
			}
		}
	}
}
