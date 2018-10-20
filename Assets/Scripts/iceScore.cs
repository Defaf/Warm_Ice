using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class iceScore : MonoBehaviour {

	public static int points = 0 ; 
	public Text pointText; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		pointText.text = (" " + points);
	}
}
