//using Rewired;
using UnityEngine;

public class ClickableTest : MonoBehaviour
{
	//private Player playerInput;

	private void Start()
	{
		//playerInput = ReInput.players.GetPlayer(0);
	}

	private void Update()
	{
		if (Input.GetButtonDown("Interact"))
		{
			Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0f));
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo) && hitInfo.transform.name == "MathNotebook")
			{
				base.gameObject.SetActive(false);
			}
		}
	}
}
