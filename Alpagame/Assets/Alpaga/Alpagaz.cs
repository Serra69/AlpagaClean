using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpagaz : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.C))
        {
 			Debug.Log("Bonjour");
            Debug.Log("prout");

        }
	}
}
