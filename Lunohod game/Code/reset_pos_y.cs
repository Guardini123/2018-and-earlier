using UnityEngine;
using System.Collections;

public class reset_pos_y : MonoBehaviour {
	public GameObject car;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Vector3 curent_position;
			curent_position = car.transform.position;
			car.transform.position = new Vector3 (curent_position.x, curent_position.y + 20, curent_position.z);
		}
	}
}
