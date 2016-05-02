using UnityEngine;
using UnityEngine.Assertions;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// シルベスター・スタローンGUIDジェネレーター.
/// </summary>
[CreateAssetMenu()]
public class SSGuidGenerator : ScriptableObject
{
	[SerializeField]
	private string header;

	[SerializeField]
	private string footer;

	[SerializeField]
	private List<string> identities;

	[SerializeField]
	private int length = 256;

	public string New
	{
		get
		{
			var builder = new StringBuilder();
			builder.Append(this.header);
			for(int i=0; i<this.length; i++)
			{
				builder.Append(this.identities[UnityEngine.Random.Range(0, this.identities.Count)]);
			}
			builder.Append(this.footer);

			return builder.ToString();
		}
	}
}
