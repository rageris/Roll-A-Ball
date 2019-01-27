using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerOfScenes : MonoBehaviour {

	public void loadthing()
	{
		SceneManager.LoadScene ("Roll a Ball");
	}

	public void loadmenu()
	{
		SceneManager.LoadScene ("Main_menu");
	}
}
