//using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	public CursorControllerScript cc;

	//private Player player;

	private bool joystickEnabled;

	public bool controlMouse;

	public bool unlockOnStart;

	public bool uiControlEnabled;

	public Selectable firstButton;

	public Selectable dummyButtonPC;

	public Selectable dummyButtonElse;

	public string buttonTag;

	private void Start()
	{
		//player = ReInput.players.GetPlayer(0);
		if (unlockOnStart & !joystickEnabled)
		{
			cc.UnlockCursor();
		}
	}

	private void OnEnable()
	{
		dummyButtonPC.Select();
		UpdateControllerType();
	}

	private void Update()
	{
		UpdateControllerType();
	}

	public void SwitchMenu()
	{
		SelectDummy();
		UpdateControllerType();
	}

	private void UpdateControllerType()
	{
	}

	private void UIUpdate()
	{
		if (!uiControlEnabled)
		{
			return;
		}
		if (joystickEnabled)
		{
			if ((EventSystem.current.currentSelectedGameObject.tag != buttonTag) & (firstButton != null))
			{
				firstButton.Select();
				firstButton.OnSelect(null);
			}
		}
		else
		{
			SelectDummy();
		}
	}

	public void EnableControl()
	{
		uiControlEnabled = true;
	}

	public void DisableControl()
	{
		uiControlEnabled = false;
	}

	private void SelectDummy()
	{
		dummyButtonPC.Select();
	}
}
