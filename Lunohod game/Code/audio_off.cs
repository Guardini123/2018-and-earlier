using UnityEngine;
using System.Collections;

public class audio_off : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioListener.pause = true;
	}
	
	// Update is called once per frame
	void Update () {
		AudioListener.pause = true;
	}
}
