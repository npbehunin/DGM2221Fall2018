using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakCollision : MonoBehaviour
{
	public BreakableObject breakobject1;
	public BreakableObject breakobject2;
	public BreakableObject breakobject3;
	public BreakableObject breakobject4;
	public BreakableObject breakobject5;
	public BreakableObject breakobject6;
	public BreakableObject breakobject7;
	public BreakableObject breakobject8;
	public BreakableObject breakobject9;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Bullet"))
		{
			Debug.Log("Bullet collision!");
			breakobject1.EnableKinematic();
			breakobject2.EnableKinematic();
			breakobject3.EnableKinematic();
			breakobject4.EnableKinematic();
			breakobject5.EnableKinematic();
			breakobject6.EnableKinematic();
			breakobject7.EnableKinematic();
			breakobject8.EnableKinematic();
			breakobject9.EnableKinematic();
			Destroy(gameObject);
		}
	}
}
