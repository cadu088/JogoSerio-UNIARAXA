using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{
		

    void Start()
    {
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
			// GameObject obj = GameObject.Find("porcoDAE"); 
			// obj.SetActive(false);




    }



    // Update is called once per frame
    void Update()
    {

			//toda vez que clicar na tela executar esse bloco
      // if (Input.GetMouseButtonDown (0)) {
			// 	obj.SetActive(!obj.active);
			// 	Debug.Log("Active");
			// }

			
    }
}
