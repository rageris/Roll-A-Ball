using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public float smooth;
	private Vector3 offset;
	private Vector3 target;

	void Start ()
    {
		offset = transform.position - player.transform.position;
	}
	
	void FixedUpdate ()
    {
		target = player.transform.position + offset;
	}
	
	void LateUpdate ()
    {
		//target.position = player.transform.position + offset; a is where i am at b is where i want to be
		transform.position = Vector3.Lerp(transform.position,  target, smooth*Time.deltaTime);
	}

}
