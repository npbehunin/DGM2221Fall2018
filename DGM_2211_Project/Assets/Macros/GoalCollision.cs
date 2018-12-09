using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalCollision : MonoBehaviour
{
	public Text LevelComplete;
	public Text ThanksForPlaying;

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			LevelComplete.gameObject.SetActive(true);
			ThanksForPlaying.gameObject.SetActive(true);
			Destroy(gameObject);
		}
	}
}