//using Rewired;
using UnityEngine;

public class CameraScript_Simple : MonoBehaviour
{
	public GameObject player;

	private int lookBehind;

	private Vector3 offset;

	//private Player playerInput;

	private void Start()
	{
		//playerInput = ReInput.players.GetPlayer(0);
		offset = base.transform.position - player.transform.position;
	}

	private void LateUpdate()
	{
		base.transform.position = player.transform.position + offset;
		base.transform.rotation = player.transform.rotation * Quaternion.Euler(0f, lookBehind, 0f);
	}
}
