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
			StartProcess();
		}
		public void Sair()
		{
			Application.Quit();
		}

		public void StartProcess(){
			List<Ancora> ancoras = new List<Ancora>();
			Stack<Ancora> sorteio = new Stack<Ancora>();
			ancoras.Add(new Ancora(1, "Anc1", "cachorroDAE", "Star1"));
			ancoras.Add(new Ancora(2, "Anc2", "cavaloDAE", "Star2"));
			ancoras.Add(new Ancora(3, "Anc3", "galinhaDAE", "Star3"));
			ancoras.Add(new Ancora(4, "Anc4", "porcoDAE", "Star4"));
			ancoras.Add(new Ancora(5, "Anc5", "vacaDAE", "Star5"));
			// for(int i = 1;i <= ancoras.Count; i++){sorteio.Add(i);};
			Debug.Log("ancoras");

			//Desativar Todas as estrelas 
			foreach(Ancora item in ancoras){
				GameObject obj = GameObject.Find(item.NameStar); 
				Debug.Log(item.NameStar);
				obj.SetActive(false);
			}
		}
}
