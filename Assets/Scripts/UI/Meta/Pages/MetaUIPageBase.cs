using UnityEngine;

public abstract class MetaUIPageBase : MonoBehaviour
{
	protected MetaUIController controller;

	public virtual void Init(MetaUIController controller)
	{
		this.controller = controller;
		Exit();
	}

	public virtual void Enter()
	{
		gameObject.SetActive(true);
	}

	public virtual void Exit()
	{
		gameObject.SetActive(false);
	}
}
