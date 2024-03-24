using TMPro;
using UnityEngine;

public class UIViewGreetingTexts : CoreUIViewBase
{
	[SerializeField] private TextMeshProUGUI label;

	public void SetText(string text)
	{
		label.text = text;
	}
}
