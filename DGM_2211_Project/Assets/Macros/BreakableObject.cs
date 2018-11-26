using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
	public Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		rb.detectCollisions = false;
		rb.useGravity = false;
	}
	
	public void EnableKinematic() {
		rb.detectCollisions = true;
		rb.useGravity = true;
	}
}
