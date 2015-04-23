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
//		GameObject lightGameObject = new GameObject("The Light");
//		Light lightComp = lightGameObject.AddComponent<Light>();
//		lightComp.color = Color.blue;
//		lightGameObject.transform.position = new Vector3(2.34, 5.43, 0);
//		lightGameObject.transform.rotation = new Vector3 (50, 330, 0);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 indexPosition = m_handModel.fingers [1].GetTipPosition ();
		//Debug.Log (indexPosition);
//		Vector3 localPosition = indexPosition.TipPosition.toUnityScaled ();
		playerPaddle.transform.position = indexPosition;
	}
}
