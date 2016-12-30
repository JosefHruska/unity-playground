using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private RigidBody rb

	void Start () {
		rb = GetComponent<RigidBody>()
	}
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal")
		float moveVertical = Input.GetAxis ("Vertical")

	}

}
