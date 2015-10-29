using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = player.transform.rotation;
	}
	/*
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Destroy(this.gameObject);
		}
	}
	*/
}
