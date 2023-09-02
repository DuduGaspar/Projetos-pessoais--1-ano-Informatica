using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {
	Rigidbody2D CorpoRigidoInimigo;
	float Vx;
	float Vy;
	float VelocidadeAndar;
	float DirecaoHorizontal;

	void Start () {
	CorpoRigidoInimigo = GetComponent<Rigidbody2D> ();
	CorpoRigidoInimigo.freezeRotation = true;
	VelocidadeAndar = 3;
	DirecaoHorizontal = 3;	
	}

	void Update () {
	MovimentoHorizontalInimigo();	
	}

	void MovimentoHorizontalInimigo(){
		Vx = CorpoRigidoInimigo.velocity.x;
		Vy = 0;
		if (Vx == 0) {
			Vx = VelocidadeAndar * DirecaoHorizontal;
			Vector2 movimento = new Vector2 (Vx, Vy);
			CorpoRigidoInimigo.velocity = movimento;
			DirecaoHorizontal = DirecaoHorizontal * -1;
		}
	}


}
