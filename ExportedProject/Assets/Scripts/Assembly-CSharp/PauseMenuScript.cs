//using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseMenuScript : MonoBehaviour
{
	public GameControllerScript gc;

	private void Update()
	{
		if (Input.anyKeyDown && gc.mouseLocked)
		{
			gc.UnlockMouse();
		}
	}
}
