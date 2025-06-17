using System.Collections.Generic;
using UnityEngine;

public class StarDisplay : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> stars;

	public void SetStars(int numStars)
	{
		foreach (GameObject star in stars)
		{
			star.SetActive(stars.IndexOf(star) < numStars);
		}
	}
}
