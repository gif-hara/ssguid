using UnityEngine;
using UnityEngine.Assertions;
using System.Collections.Generic;

public class ExampleScript : MonoBehaviour
{
	[SerializeField]
	private SSGuidGenerator generator;

	[SerializeField]
	private int generateCount;

	void Start()
	{
		for(int i=0; i<this.generateCount; i++)
		{
			Debug.Log(this.generator.New);
		}
	}
}
