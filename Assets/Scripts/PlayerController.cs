using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float position;
	public float moveSpeed;
	public float rotateSpeed;
	public GameObject gameController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKey("Foreward"))
		if (Input.GetKey(KeyCode.UpArrow))
		{
			//position = this.transform.position.x;
			//this.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y+speed,this.transform.position.z);
			transform.position += transform.up*moveSpeed;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			//this.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y-speed,this.transform.position.z);
			transform.position -= transform.up*moveSpeed;
		}
		/*
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.position = new Vector3 (this.transform.position.x+speed,this.transform.position.y,this.transform.position.z);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.position = new Vector3 (this.transform.position.x-speed,this.transform.position.y,this.transform.position.z);
		}
		*/
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Rotate (Vector3.back*rotateSpeed);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Rotate (Vector3.forward*rotateSpeed);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Coin") {
			//Destroy(other.gameObject);
			gameController.GetComponent<GameController>().collectCoin(other.gameObject);
		}
	}
}
