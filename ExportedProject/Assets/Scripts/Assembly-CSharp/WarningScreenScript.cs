//using Rewired;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarningScreenScript : MonoBehaviour
{
	//public Player player;

	private void Start()
	{
		//player = ReInput.players.GetPlayer(0);
	}

	private void Update()
	{
		if (Input.anyKeyDown)
		{
			SceneManager.LoadScene("MainMenu");
		}
	}
}
