using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agoravai : MonoBehaviour
{
  bool mouseDentroDoObjeto;
	public GameObject obj;
	public string NameObj;

	void Start () {
		mouseDentroDoObjeto = false;
		obj = GameObject.Find(NameObj);
		obj.SetActive(true);
	}

	void Update () {
		if (mouseDentroDoObjeto == true) {
			if (Input.GetMouseButtonDown (0)) {
				obj.SetActive(!obj.active);
				Debug.Log("Active");
			}
			// obj.SetActive(obj.active ? false : true);
			Debug.Log("fora do Active");
		}
	}

	void OnMouseEnter(){
		mouseDentroDoObjeto = true;
	}

	void OnMouseExit(){
		mouseDentroDoObjeto = false;
	}
}
