using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioListenerScript : MonoBehaviour {

	public float speed = 100.0f;

	void Start () {
	
	}
	
	void Update () {
		transform.position += new Vector3 (0,0,Time.deltaTime * speed);
	}
}
