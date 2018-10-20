using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public CharacterController2D control; 
	float horizontalMove = 0f; 
	public float runSpeed = 40f; 
	bool jump = false; 
	bool slide = false ; 

	public Animator anim; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		horizontalMove = Input.GetAxis ("Horizontal") * runSpeed ;
		anim.SetFloat ("speed", Mathf.Abs(horizontalMove));
		if(Input.GetButtonDown("Jump")){// if pree Space bar 
			jump = true; 
			anim.SetBool ("isJump",true);
		}
		if(Input.GetButtonDown("Slide")){
			slide = true;
		}else if(Input.GetButtonDown("Slide")){
			slide = false ; 
		}
	}

	public void OnLoading(){
		anim.SetBool ("isJump",false);
	}

	public void OnCrouch(bool slide){
		anim.SetBool ("slide", slide); 
	}

	void FixedUpdate(){
		control.Move (horizontalMove * Time.fixedDeltaTime , slide, jump);
		jump = false; 
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("coin")){
			iceScore.points += 1; 
			Destroy (col.gameObject);
		}
		else if(col.CompareTag("item")){
			itemScore.items += 10; 
			Destroy (col.gameObject);
		}
	}
		
}
