using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {


	public ParticleSystem snowPS; 
	public int emitVol; 
	public float timeVar = 0 ; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeVar += Time.deltaTime; 
		if(timeVar > .5 ) {//"JSON var should be float "
			timeVar = 0 ;
			emitVol +=5 ; //"JSON var"
		}

		snowPS.Emit(emitVol);

	}
}
