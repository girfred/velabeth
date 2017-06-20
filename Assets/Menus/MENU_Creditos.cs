using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class MENU_Creditos : MonoBehaviour {

	 public Button BotaoVoltar;
     public string nomeCenaMenu = "MENU";
     private string nomeDaCena;
	 
 void Awake(){
	 DontDestroyOnLoad (transform.gameObject);
	 //resolucoesSuportadas = Screen.resolutions;
	}

 void Start () {
	 nomeDaCena = SceneManager.GetActiveScene ().name;
	 Cursor.visible = true;
	 Time.timeScale = 1;
	 

	 // =========SETAR BOTOES==========//
	 BotaoVoltar.onClick = new Button.ButtonClickedEvent();
	 BotaoVoltar.onClick.AddListener(() => Voltar());
	}
 private void Voltar()
{
    SceneManager.LoadScene(nomeCenaMenu);
}

 //===========VOIDS NORMAIS=========//
 void Update(){
	 if (SceneManager.GetActiveScene ().name != nomeDaCena) {
		 //AudioListener.volume = VOLUME;
		 Destroy (gameObject);
	 }
 }
 
}