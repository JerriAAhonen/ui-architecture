using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RequestableUIView_CornerButton : RequestableUIViewBase
{
	[SerializeField] private Button button;

	public event Action OnClick;

	protected override void Awake()
	{
		base.Awake();
		button.onClick.AddListener(OnButton);
	}

	private void OnButton()
	{
		OnClick?.Invoke();
	}
}
