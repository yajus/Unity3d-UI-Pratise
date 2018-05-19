using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1ChangetoScene2 : MonoBehaviour 
{

	public void OnStartGame(string Scene)
	{
		Application.LoadLevel(Scene);
	}
		
}

