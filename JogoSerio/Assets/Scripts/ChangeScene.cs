using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string Scene;

		public void SceneChange()
		{
			SceneManager.LoadScene(Scene);
			Debug.Log("teste ");
		}
		public void Sair()
		{
			Application.Quit();
		}
}
