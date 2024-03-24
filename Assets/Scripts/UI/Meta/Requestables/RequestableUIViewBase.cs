using System.Collections.Generic;
using UnityEngine;

public class RequestableUIViewBase : MonoBehaviour
{
	private readonly HashSet<object> requesters = new();

	protected virtual void Awake()
	{
		SetVisible(false);
	}

	public void Request(object requester)
	{
		requesters.Add(requester);
		SetVisible(true);
	}

	public void RemoveRequester(object requester)
	{
		requesters.Remove(requester);
		if (requesters.Count == 0)
		{
			SetVisible(false);
		}
	}

	private void SetVisible(bool visible)
	{
		gameObject.SetActive(visible);
	}
}
