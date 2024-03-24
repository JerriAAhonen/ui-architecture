using TMPro;
using UnityEngine;

public class RequestableUIView_TextLabel : RequestableUIViewBase
{
	[SerializeField] private TextMeshProUGUI label;

	public void SetText(string text)
	{
		label.text = text;
	}
}