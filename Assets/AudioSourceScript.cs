using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioSourceScript : MonoBehaviour {

	private AudioSource sound;
	public AudioClip audioClip;
	public int soundPitch = 440;
	public float speed = 100.0f;

	void Start () {
		sound = gameObject.GetComponent <AudioSource> ();
	}
	
	void Update () {
		
		transform.position += new Vector3 (Time.deltaTime * speed, 0, 0);

		sound.clip = audioClip;
		sound.pitch = soundPitch;
		sound.Play ();
	}
}
