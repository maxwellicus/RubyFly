using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int coinsCollected = 0;
	private int coinsTotal;

	// Use this for initialization
	void Start () {
		coinsTotal = GameObject.FindGameObjectsWithTag ("Coin").Length;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void collectCoin(GameObject coin)
	{
		Destroy (coin);
		coinsCollected += 1;
		print (coinsCollected);
		if (coinsCollected == coinsTotal) {
			print ("You Win");
		}
	}
}
