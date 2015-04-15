using UnityEngine;
using System.Collections;
using Leap;

public class HandPaddle : MonoBehaviour {
	public HandModel m_handModel;
	public GameObject playerPaddle;

	// Use this for initialization
	void Start () {
		m_handModel = transform.GetComponent<HandModel>();
		playerPaddle = GameObject.Find ("PlayerPaddle");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 indexPosition = m_handModel.fingers [1].GetTipPosition ();
		Debug.Log (indexPosition);
//		Vector3 localPosition = indexPosition.TipPosition.toUnityScaled ();
		playerPaddle.transform.position = indexPosition;
	}
}
