using UnityEngine;
using System.Collections;
using Leap;

public class BallScript : MonoBehaviour {
	public GameObject ball;
	public GameObject hand;

	void Start () {
		ball = GameObject.Find ("Ball");
		hand = GameObject.Find ("Hand");
		IgnoreCollisionsWithHands (ball,true);
	}
	public void IgnoreCollisionsWithHands(GameObject to_ignore, bool ignore = true) {
		ball = to_ignore;
		Leap.Utils.IgnoreCollisions(hand.gameObject, to_ignore, ignore);
	}
	// Update is called once per frame
	void Update () {
		IgnoreCollisionsWithHands (ball,true);
	}
}
