using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Animal : MonoBehaviour
{
  public GameObject animal;
  public GameObject estrela;
  public Image refencia;
	public Sprite imageCor;
	public Sprite imagePB;
	public bool escolhido = false;
	public bool correto = false;

	public Animal(GameObject Animal, GameObject Estrela, Sprite ImageCor, Sprite ImagePB){
		this.animal = Animal;
		this.estrela = Estrela;
		this.imageCor = ImageCor;
		this.imagePB = ImagePB;
		this.escolhido = false;
		this.correto = false;
	}

  //Verificar ao ser clicado se é o escolhido, se for retorna true;
	public bool CheckPoint(){
		if(!escolhido && correto){
			animal.SetActive(false);
			estrela.SetActive(true);
			refencia.sprite = imageCor;
			escolhido = true;
			return true;
		}
		return false;
	}

  //Define o animal como o da rodada, se já tiver escolhido ou já esteja definido como o da rodada retorna false
	public bool CreateCheck(){
		if(!correto && !escolhido){
			correto = true;
			return true;
		}
		return false;
	}

	// seta o local da referencia
	public void SetLocalRef(Image refs){
		refencia = refs;
		refencia.sprite = imagePB;
	}
}