using System.Collections.Generic;
using UnityEngine;

public class RequestableUIViewBase : MonoBehaviour, IRequestableUIView
{
	private readonly HashSet<object> requesters = new();

	private void Awake()
	{
		SetVisible(false);
	}

	public void Request(object requester)
	{
		if (requesters.Contains(requester))
		{
			Debug.LogError("This requester has already been registered");
			return;
		}

		requesters.Add(requesters);
		SetVisible(true);
	}

	public void RemoveRequest(object requester)
	{
		if (!requesters.Contains(requester))
		{
			Debug.LogError("No such requesters have been registered");
			return;
		}

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
