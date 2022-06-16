using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class vb_anim : MonoBehaviour
{
	public GameObject cube;
	public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
			// Vb.RegisterOnButtonPressed(OnButtonPressed);
			// Vb.RegisterOnButtonReleased(OnButtonReleased);


			cubeAni.GetComponent<Animator>();
        
    }

		public void OnButtonPressed(VirtualButtonBehaviour vb){
			cubeAni.Play("TesteAnimation");
		}

		public void OnButtonReleased(VirtualButtonBehaviour vb){
			cubeAni.Play("none");
		}

    // Update is called once per frame
    void Update()
    {
        
    }
}
