using System;
using System.Collections.Generic;
using UnityEngine;

public class MetaUIController : MonoBehaviour
{
	[SerializeField] private MetaUINavigationSideBar sideMenu;
	[Header("Requestables")]
	[SerializeField] private RequestableUIView_CornerButton playButton;
	[SerializeField] private RequestableUIView_CornerButton backButton;
	[SerializeField] private RequestableUIView_TextLabel topRightTextLabel;

	private Dictionary<Type, Component> pages;
	private MetaUIPageBase currentPage;

	public RequestableUIView_CornerButton PlayButton => playButton;
	public RequestableUIView_CornerButton BackButton => backButton;
	public RequestableUIView_TextLabel TopRightTextLabel => topRightTextLabel;

	public void Init()
	{
		// Fetch all main menu pages and initialize them
		pages = TypeUtil.GetDerivedTypesAndInstances<MetaUIPageBase>(gameObject);
		foreach (var (type, instance) in pages)
		{
			if (instance is MetaUIPageBase view)
			{
				view.Init(this);
			}
		}

		// Initialize side bar navigation
		sideMenu.Init(this);

		// Switch to landing page
		SwitchPage<MetaUIPage_NormalLevels>();
	}

	public void SetVisible(bool visible)
	{
		gameObject.SetActive(visible);
	}

	public void SwitchPage<T>() where T : MetaUIPageBase
	{
		if (pages == null)
			throw new Exception("MetaUIController not initialized!");

		if (currentPage)
			currentPage.Exit();
		currentPage = TypeUtil.GetInstanceOfType<T>(pages);
		currentPage.Enter();
	}
}
