using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ancora : MonoBehaviour
{
	public int ID;
	public string Name;
	public string NameAnimal;
	public string NameStar;

	public Ancora(int id, string name, string nameAnimal,string nameStar){
		this.ID = id;
		this.Name = name;
		this.NameAnimal = nameAnimal;
		this.NameStar = nameStar;
	}
}
