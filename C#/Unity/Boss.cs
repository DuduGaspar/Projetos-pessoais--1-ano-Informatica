using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

	Rigidbody2D CorpoRigidoInimigo;
	float Vx;
	float Vy;
	float VelocidadeAndar;
	float DirecaoHorizontal;

	void Start () {
		CorpoRigidoInimigo = GetComponent<Rigidbody2D> ();
		CorpoRigidoInimigo.freezeRotation = true;
		VelocidadeAndar = 3;
		DirecaoHorizontal = 4;	
	}

	void Update () {
		MovimentoHorizontal();	
	}

	void MovimentoHorizontal(){
		Vx = CorpoRigidoInimigo.velocity.x;
			Vx = VelocidadeAndar * DirecaoHorizontal;
			Vector2 movimento = new Vector2 (Vx, Vy);
			CorpoRigidoInimigo.velocity = movimento;
	}
}
