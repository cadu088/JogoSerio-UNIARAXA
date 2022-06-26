using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using System.Linq; 
using UnityEngine.UI;

// using UnityEngine.Random;
// using System.Random;
// using System;

public class Starting : MonoBehaviour
{
		public GameObject Anc1;
		public GameObject Anc2;
		public GameObject Anc3;
		public GameObject Anc4;
		public GameObject Anc5;
		
		public GameObject star1;
		public GameObject star2;
		public GameObject star3;
		public GameObject star4;
		public GameObject star5; 

		//objetos image
		public Image ref1; 
		public Image ref2; 
		public Image ref3; 
		public Image ref4; 
		public Image ref5; 

		public Image refPrincipal; 

		//imagens
		public Sprite imageCor1;
		public Sprite imagePB1;
		public Sprite imageCor2;
		public Sprite imagePB2;
		public Sprite imageCor3;
		public Sprite imagePB3;
		public Sprite imageCor4;
		public Sprite imagePB4;
		public Sprite imageCor5;
		public Sprite imagePB5;

		private List<Animal> animalSort = new List<Animal>();

    void Start()
    {
			Debug.Log("Inicio");
			Iniciar();
			Debug.Log("Inicio 2");
			// List<Ancora> ancoras = new List<Ancora>();
			// Stack<Ancora> sorteio = new Stack<Ancora>();
			// ancoras.Add(new Ancora(1, "Anc1", "cachorroDAE", "Star1"));
			// ancoras.Add(new Ancora(2, "Anc2", "cavaloDAE", "Star2"));
			// ancoras.Add(new Ancora(3, "Anc3", "galinhaDAE", "Star3"));
			// ancoras.Add(new Ancora(4, "Anc4", "porcoDAE", "Star4"));
			// ancoras.Add(new Ancora(5, "Anc5", "vacaDAE", "Star5"));
			// // for(int i = 1;i <= ancoras.Count; i++){sorteio.Add(i);};
			// Debug.Log("ancoras");

			// //Desativar Todas as estrelas 
			// foreach(Ancora item in ancoras){
			// 	GameObject obj = GameObject.Find(item.NameStar); 
			// 	Debug.Log(item.NameStar);
			// 	obj.SetActive(false);
			// }
			// GameObject obj = GameObject.Find("porcoDAE"); 
			// obj.SetActive(false);
    }

		void Iniciar(){
			//Animais
			//animal é o animal da ancora

			List<Animal> animais = new List<Animal>(){
				new Animal(Anc1, star1, imageCor1, imagePB1),
				new Animal(Anc2, star2, imageCor2, imagePB2),
				new Animal(Anc3, star3, imageCor3, imagePB3),
				new Animal(Anc4, star4, imageCor4, imagePB4),
				new Animal(Anc5, star5, imageCor5, imagePB5)
			};

			List<Image> Refencias = new List<Image>(){
				ref1,
				ref2,
				ref3,
				ref4,
				ref5
			};

			//Desativar estrelas;
			foreach (Animal obj in animais){
				obj.estrela.SetActive(false);
				Debug.Log("Desativando estrela");
			}

			// criar uma temporaria para retirar os animais pelo sorteio
			List<Animal> tempAnimais = animais;
			// Random gerador = new Random();
			Debug.Log("for");
			
			List<int> sorteio = new List<int>();

			while (sorteio.Count < 5){
				int index = Random.Range(0,tempAnimais.Count);
				if(!sorteio.Contains(index)){
					sorteio.Add(index);
				}
			}
			Debug.Log("sorteio");

			//add a lista
			foreach (int n in sorteio){
				animalSort.Add(tempAnimais[n]);
			}

			//setar as refs
			for (int b = 0; b < animalSort.Count; b++){
				animalSort[b].SetLocalRef(Refencias[b]);
			}

			Debug.Log("Resultado");
			foreach (Animal obj in animalSort){
				Debug.Log(obj.animal.name);
			}

			animalSort[0].CreateCheck();
			refPrincipal.sprite = animalSort[0].imageCor;
			Debug.Log(animalSort[0].animal.name);
		}



    // Update is called once per frame
    void Update()
    {
			// pegar clicks na tela
			if (Input.GetMouseButtonDown(0)) {
				Debug.Log("Click na tela");
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
				RaycastHit hit;  
				if (Physics.Raycast(ray, out hit)) {  
					//pega o estado
					Debug.Log("Click no objeto: " + hit.transform.name);

					//percorrer os objetos que temos para saber se é o correto;
					foreach(Animal obj in animalSort){
						if(obj.animal.name == hit.transform.name){
							Debug.Log("Peguei o objeto: " + obj.animal.name);
							// infomar o click para decidir se é o correto ou não
							bool acerto = obj.CheckPoint();

							if(acerto){

								//Chamar o proximo
								Animal proximo = animalSort.First(x => !x.correto && !x.escolhido);
								if(!proximo.CreateCheck()){ 
									Debug.Log("Falha ao escolher obj");		
								}else {
									Debug.Log("Deu good " + proximo.animal.name);	
									refPrincipal.sprite = proximo.imageCor;
								}			
							}else{
 								Handheld.Vibrate();
							}
						}
					}
				}
			}
    }
}
