using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	GameObject startGame, startHow, startCredits;
	public int boxOne;
	// Use this for initialization
	void Start () {
		startGame = GameObject.Find ("Start");
		startHow = GameObject.Find ("HowToPlay");
		startCredits = GameObject.Find ("Credits");

	
	}
	void OnTriggerEnter(Collider other){
		Debug.Log ("you made it here");
		if (boxOne == -1) {
			Application.LoadLevel (0);
			Debug.Log("Start");
		}
		if (boxOne == 0) {
			//Application.LoadLevel (2);
			Debug.Log("How to play");
		}
		if (boxOne == 1) {
			//Application.LoadLevel (3);
			Debug.Log("Credits");
			Application.LoadLevel (1);
		}
	}
//	void OnCollisionEnter(Collision col){
//		if ("Start" == col.gameObject.tag) {
//			Application.LoadLevel (1);
//			Debug.Log("Start");
//		}
//		if (col.gameObject.tag == "HowToPlay") {
//			//Application.LoadLevel (2);
//			Debug.Log("How to play");
//		}
//		if (col.gameObject.tag == "Credits") {
//			//Application.LoadLevel (3);
//			Debug.Log("Credits");
//		}
//	}

	// Update is called once per frame
	void Update () {

	
	}
}
