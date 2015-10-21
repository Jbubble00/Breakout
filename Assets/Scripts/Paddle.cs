using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float paddlespeed = 1f;


	private Vector3 playerPos = new Vector3 (0, -9.5f, 0);

	// Update is called once per frame
	void Update () 
	{
		float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddlespeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -8f, 8f), -9.5f, 4.25f);
		transform.position = playerPos;

	}
}
