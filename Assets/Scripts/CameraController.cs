using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position = player.transform.position;
		this.transform.position = new Vector3 (
			player.transform.position.x,
			player.transform.position.y,
			this.transform.position.z);
		this.transform.rotation = player.transform.rotation;
			//new Quaternion(
			//player.transform.rotation.x,
			//player.transform.rotation.y,
			//this.transform.rotation.z);
	}
}
