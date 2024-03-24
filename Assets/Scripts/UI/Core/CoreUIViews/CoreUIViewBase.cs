using UnityEngine;

public abstract class CoreUIViewBase : MonoBehaviour
{
	public virtual void SetVisible(bool visible)
	{
		gameObject.SetActive(visible);
	}
}
