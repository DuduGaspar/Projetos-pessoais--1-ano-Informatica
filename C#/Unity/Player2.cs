using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour {
	float Vx; 
	float Vy;	
	float VelocidadeHorizontal;
	float VelocidadePular;
	float DirecaoHorizontal;
	Rigidbody2D CorpoRigido;
	BoxCollider2D Colisor; 
	bool apertou;
	int vida;
	int chave;
	SpriteRenderer Renderer;
	Animator personagemAnimator;
	float TempoBonus;
	bool BonusVelocidadeAndar;
	bool BonusVelocidadePular;


	void Start () {
		Vx = 0;		
		Vy = 0;
		chave = 0;
		DirecaoHorizontal = 0;		
		VelocidadeHorizontal = 10;		
		VelocidadePular	= 10;		
		CorpoRigido = GetComponent<Rigidbody2D> ();		
		Colisor = GetComponent<BoxCollider2D> (); 	
		CorpoRigido.freezeRotation = true;			
		CorpoRigido.gravityScale = 1.2f;	
		apertou = false;
		vida = 1;
		Renderer = GetComponent<SpriteRenderer>();
		personagemAnimator = gameObject.GetComponent<Animator> ();
		TempoBonus = 4.0f;
	}


	void Update () {
		MovimentoHorizontal();
		Pular();

	}
	void Pular(){
		apertou = Input.GetKey (KeyCode.Space);
		bool tocou = Colisor.IsTouchingLayers ();

		if (apertou == true && tocou == true) {
			Vx = CorpoRigido.velocity.x;
			Vy = VelocidadePular;
			Vector2 pulo = new Vector2 (Vx, Vy);
			CorpoRigido.velocity = pulo;
			personagemAnimator.SetBool ("pulando", true);
		}
	}

	void MovimentoHorizontal(){
		if (apertou = Input.GetKey (KeyCode.A)) {
			DirecaoHorizontal = -1;
			Renderer.flipX = true;
			Vx = VelocidadeHorizontal * DirecaoHorizontal;
			Vy = CorpoRigido.velocity.y;
			Vector2 andar = new Vector2 (Vx, Vy);
			CorpoRigido.velocity = andar;
		}if (apertou = Input.GetKey (KeyCode.D)) {
			DirecaoHorizontal = 1;
			Renderer.flipX = false;
			Vx = VelocidadeHorizontal * DirecaoHorizontal;
			Vy = CorpoRigido.velocity.y;
			Vector2 andar = new Vector2 (Vx, Vy);
			CorpoRigido.velocity = andar;
		} else {
			DirecaoHorizontal = 0;
		}
		if (DirecaoHorizontal != 0) {
			personagemAnimator.SetBool ("andando", true);
			personagemAnimator.SetBool ("parado",false);
			personagemAnimator.SetBool ("pulando",false);
		}
		if (DirecaoHorizontal == 0) {
			personagemAnimator.SetBool ("andando", false);
			personagemAnimator.SetBool ("pulando",false);
			personagemAnimator.SetBool ("parado",true);
		}
	}

	void OnCollisionEnter2D(Collision2D objetoTocado){
		string tagTocada = objetoTocado.gameObject.tag;

		if (tagTocada == "maçã") {
			vida=vida+1; 	
			Destroy (objetoTocado.gameObject);					
		}

		if (tagTocada == "inimigo") {
			vida = vida - 1;
			if (vida <= 0) {
				SceneManager.LoadScene ("GAME OVER");
			}
		}

		if (tagTocada == "chave") {
			chave = chave + 1;
			if (chave == 4) {
				Destroy (GameObject.FindGameObjectWithTag ("porta"));
			}
		}
		if (tagTocada == "final") {
			SceneManager.LoadScene ("cena2");
		}
		if (tagTocada == "espinho") {
			vida = vida - 100;
			SceneManager.LoadScene ("GAME OVER");
		}
		if (tagTocada == "porta2") {
			SceneManager.LoadScene ("cena3");
		}
		if (tagTocada == "porta3") {
			SceneManager.LoadScene ("FINAL");
		}
	}

	void OnTriggerEnter2D(Collider2D objetoTriggerTocado){
		string tagTocadaTrigger = objetoTriggerTocado.gameObject.tag;
		if (tagTocadaTrigger == "portal") {
			Vector2 posicaoDestino = GameObject.FindGameObjectWithTag ("portal2").GetComponent<Transform> ().position;
			float xDestino = posicaoDestino.x;
			float yDestino = posicaoDestino.y;
			xDestino = xDestino + 3.5f;
			transform.position = new Vector2(xDestino,yDestino);
		}
		if (tagTocadaTrigger == "portal2") {
			Vector2 posicaoDestino = GameObject.FindGameObjectWithTag ("portal").GetComponent<Transform> ().position;
			float xDestino = posicaoDestino.x;
			float yDestino = posicaoDestino.y;
			xDestino = xDestino + 3.5f;
			transform.position = new Vector2(xDestino,yDestino);
		}
		if (tagTocadaTrigger == "botao") {
			GameObject[] vetorObjetos;
			vetorObjetos= GameObject.FindGameObjectsWithTag ("espinho");
			int qtdObjetos = vetorObjetos.Length;
			for (int i = 0; i < qtdObjetos; i++) {
				Destroy (vetorObjetos[i]); 
			}
		}
		if (tagTocadaTrigger == "pena2") {
			VelocidadeHorizontal = VelocidadeHorizontal + 5;
			VelocidadePular = VelocidadePular + 3;
			Invoke ("DesativarBonusVelocidadeAndar", TempoBonus);
			Destroy (objetoTriggerTocado.gameObject);

		}
		if (tagTocadaTrigger == "boss") {
			vida = 0;
			SceneManager.LoadScene ("GAME OVER");	
		}

	}

	void DesativarBonusVelocidadeAndar(){
		VelocidadeHorizontal = 10;
		VelocidadePular = 10;
	}
}