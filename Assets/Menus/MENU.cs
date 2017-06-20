using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class MENU : MonoBehaviour {

	 public Button BotaoJogar,BotaoOpcoes,BotaoCreditos,BotaoSair;
	 [Space(20)]
//	 public Slider BarraVolume;
//	 public Toggle CaixaModoJanela;
//	 public Dropdown Resolucoes, Qualidades;
//	 public Button BotaoVoltar, BotaoSalvarPref;
	 [Space(20)]
//	 public Text textoVol;
	 public string nomeCenaJogo = "scene";
     public string nomeCenaMenu = "MENU";
     public string nomeCenaMenuOpcoes = "MENU - Opcoes";
     public string nomeCenaMenuCreditos = "MENU - Creditos";
     private string nomeDaCena;
//	 private float VOLUME;
//	 private int qualidadeGrafica, modoJanelaAtivo, resolucaoSalveIndex;
//	 private bool telaCheiaAtivada;
//	 private Resolution[] resolucoesSuportadas;
	 public Texture TexturaCreditos,TexturaFundosMenu,TexturaGraficos;
//	 private bool EstaNoMenuPrincipal,EstaNosGraficos,EstaNosCreditos;
	 
 void Awake(){
	 DontDestroyOnLoad (transform.gameObject);
	 //resolucoesSuportadas = Screen.resolutions;
	}

 void Start () {
//	 EstaNoMenuPrincipal = true;
	 //Opcoes (false);
	 //ChecarResolucoes ();
	 //AjustarQualidades ();
	 //
	 /*if (PlayerPrefs.HasKey ("RESOLUCAO")) {
		 int numResoluc = PlayerPrefs.GetInt ("RESOLUCAO");
		 if (resolucoesSuportadas.Length <= numResoluc) {
			PlayerPrefs.DeleteKey ("RESOLUCAO");
		 }
	 }*/
	 //
	 nomeDaCena = SceneManager.GetActiveScene ().name;
	 Cursor.visible = true;
	 Time.timeScale = 1;
	 //
	 //BarraVolume.minValue = 0;
	 //BarraVolume.maxValue = 1;

	 //=============== SAVES===========//
	 /*if (PlayerPrefs.HasKey ("VOLUME")) {
		 VOLUME = PlayerPrefs.GetFloat ("VOLUME");
		 BarraVolume.value = VOLUME;
	 } else {
		 PlayerPrefs.SetFloat ("VOLUME", 1);
		 BarraVolume.value = 1;
	 }*/
	 //=============MODO JANELA===========//
	 /*if (PlayerPrefs.HasKey ("modoJanela")) {
		 modoJanelaAtivo = PlayerPrefs.GetInt ("modoJanela");
		 if (modoJanelaAtivo == 1) {
			 Screen.fullScreen = false;
			 CaixaModoJanela.isOn = true;
		 } else {
			 Screen.fullScreen = true;
			 CaixaModoJanela.isOn = false;
		 }
	 } else {
		 modoJanelaAtivo = 0;
		 PlayerPrefs.SetInt ("modoJanela", modoJanelaAtivo);
		 CaixaModoJanela.isOn = false;
		 Screen.fullScreen = true;
	 }*/
	 //========RESOLUCOES========//
	 /*if (modoJanelaAtivo == 1) {
		 telaCheiaAtivada = false;
	 } else {
		telaCheiaAtivada = true;
	 }
	 if (PlayerPrefs.HasKey ("RESOLUCAO")) {
		 resolucaoSalveIndex = PlayerPrefs.GetInt ("RESOLUCAO");
		 Screen.SetResolution(resolucoesSuportadas[resolucaoSalveIndex].width,resolucoesSuportadas[resolucaoSalveIndex].height,telaCheiaAtivada);
		 Resolucoes.value = resolucaoSalveIndex;
	 } else {
		 resolucaoSalveIndex = (resolucoesSuportadas.Length -1);
		 Screen.SetResolution(resolucoesSuportadas[resolucaoSalveIndex].width,resolucoesSuportadas[resolucaoSalveIndex].height,telaCheiaAtivada);
		 PlayerPrefs.SetInt ("RESOLUCAO", resolucaoSalveIndex);
		 Resolucoes.value = resolucaoSalveIndex;
	 }
	 //=========QUALIDADES=========//
	 if (PlayerPrefs.HasKey ("qualidadeGrafica")) {
		 qualidadeGrafica = PlayerPrefs.GetInt ("qualidadeGrafica");
		 QualitySettings.SetQualityLevel(qualidadeGrafica);
		 Qualidades.value = qualidadeGrafica;
	 } else {
		 QualitySettings.SetQualityLevel((QualitySettings.names.Length-1));
		 qualidadeGrafica = (QualitySettings.names.Length-1);
		 PlayerPrefs.SetInt ("qualidadeGrafica", qualidadeGrafica);
		 Qualidades.value = qualidadeGrafica;
	}*/

	 // =========SETAR BOTOES==========//
	 BotaoJogar.onClick = new Button.ButtonClickedEvent();
	 //BotaoOpcoes.onClick = new Button.ButtonClickedEvent();
     BotaoCreditos.onClick = new Button.ButtonClickedEvent();
	 BotaoSair.onClick = new Button.ButtonClickedEvent();
	 //BotaoVoltar.onClick = new Button.ButtonClickedEvent();
	 //BotaoSalvarPref.onClick = new Button.ButtonClickedEvent();
	 BotaoJogar.onClick.AddListener(() => Jogar());
	 //BotaoOpcoes.onClick.AddListener(() => Opcoes());
     BotaoCreditos.onClick.AddListener(() => Creditos());
	 BotaoSair.onClick.AddListener(() => Sair());
	 //BotaoVoltar.onClick.AddListener(() => Voltar());
	 //BotaoSalvarPref.onClick.AddListener(() => SalvarPreferencias());
	}
 //=========VOIDS DE CHECAGEM==========//
 /*private void ChecarResolucoes(){
	 Resolution[] resolucoesSuportadas = Screen.resolutions;
	 Resolucoes.options.Clear ();
	 for(int y = 0; y < resolucoesSuportadas.Length; y++){
		Resolucoes.options.Add(new Dropdown.OptionData() { text = resolucoesSuportadas[y].width + "x" + resolucoesSuportadas[y].height });
	 }
	 Resolucoes.captionText.text = "Resolucao";
 }
 private void AjustarQualidades(){
	 string[] nomes = QualitySettings.names;
	 Qualidades.options.Clear ();
	 for(int y = 0; y < nomes.Length; y++){
		Qualidades.options.Add(new Dropdown.OptionData() { text = nomes[y] });
	 }
	 Qualidades.captionText.text = "Qualidade";
 }*/
 private void Opcoes(){
        SceneManager.LoadScene(nomeCenaMenuOpcoes);

             /*BotaoJogar.gameObject.SetActive (!ativarOP);
             BotaoOpcoes.gameObject.SetActive (!ativarOP);
             BotaoSair.gameObject.SetActive (!ativarOP);
             //
             textoVol.gameObject.SetActive (ativarOP);
             BarraVolume.gameObject.SetActive (ativarOP);
             CaixaModoJanela.gameObject.SetActive (ativarOP);
             Resolucoes.gameObject.SetActive (ativarOP);
             Qualidades.gameObject.SetActive (ativarOP);
             BotaoVoltar.gameObject.SetActive (ativarOP);
             BotaoSalvarPref.gameObject.SetActive (ativarOP);
             */
        
    }

/*private void Voltar()
{
    SceneManager.LoadScene(nomeCenaMenu);
}
    //=========VOIDS DE SALVAMENTO==========//
    private void SalvarPreferencias(){
	 if (CaixaModoJanela.isOn == true) {
		 modoJanelaAtivo = 1;
		 telaCheiaAtivada = false;
	 } else {
		 modoJanelaAtivo = 0;
		 telaCheiaAtivada = true;
	 }
	 PlayerPrefs.SetFloat ("VOLUME", BarraVolume.value);
	 PlayerPrefs.SetInt ("qualidadeGrafica", Qualidades.value);
	 PlayerPrefs.SetInt ("modoJanela", modoJanelaAtivo);
	 PlayerPrefs.SetInt ("RESOLUCAO", Resolucoes.value);
	 resolucaoSalveIndex = Resolucoes.value;
	 AplicarPreferencias ();
 }
 private void AplicarPreferencias(){
	 VOLUME = PlayerPrefs.GetFloat ("VOLUME");
	 QualitySettings.SetQualityLevel(PlayerPrefs.GetInt ("qualidadeGrafica"));
	 Screen.SetResolution(resolucoesSuportadas[resolucaoSalveIndex].width,resolucoesSuportadas[resolucaoSalveIndex].height,telaCheiaAtivada);
 }*/
 //===========VOIDS NORMAIS=========//
 void Update(){
	 if (SceneManager.GetActiveScene ().name != nomeDaCena) {
		 //AudioListener.volume = VOLUME;
		 Destroy (gameObject);
	 }
 }
 private void Jogar(){
	SceneManager.LoadScene (nomeCenaJogo);
 }

private void Creditos()
{
    SceneManager.LoadScene(nomeCenaMenuCreditos);
}
    private void Sair(){
	 Application.Quit ();
 }
 
 /*void OnGUI (){
	 //=============================== SE ESTA NA PARTE PRINCIPAL DO MENU ===================//
	 if (EstaNoMenuPrincipal == true) {
//		 GUI.skin.button = EstiloDosBotoesPrincipais;
		 GUI.DrawTexture(new Rect(Screen.width/2-Screen.width/2,Screen.height/2-Screen.height/2,Screen.width,Screen.height),TexturaFundosMenu);
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/16,Screen.height/2-Screen.height/5.5f,Screen.width/8,Screen.height/14),"Jogar")){
			Application.LoadLevel ("AI");// NOME DA CENA DO SEU JOGO
		 }
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/16,Screen.height/2-Screen.height/16,Screen.width/8,Screen.height/14),"Opçoes")){
			 EstaNoMenuPrincipal = false;
			 EstaNosGraficos = true;
		 }
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/16,Screen.height/2+Screen.height/16,Screen.width/8,Screen.height/14),"Creditos")){
			 EstaNoMenuPrincipal = false;
			 EstaNosCreditos = true;
		 }
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/16,Screen.height/2+Screen.height/5.5f,Screen.width/8,Screen.height/14),"Sair")){
			Application.Quit ();
		 }
	 }
	 //=============================== SE ESTA NA PARTE DOS GRAFICOS DO MENU ===================//
	 if (EstaNosGraficos == true) {
		 GUI.skin.button = EstiloDosBotoesGraficos;
		 GUI.DrawTexture(new Rect(Screen.width/2-Screen.width/2,Screen.height/2-Screen.height/2,Screen.width,Screen.height),TexturaGraficos);
		 GUI.DrawTexture(new Rect(Screen.width/2-Screen.width/3,Screen.height/2-Screen.height/2.5f,Screen.width/8,Screen.height/14),QualidadeGrafica);
		 GUI.DrawTexture(new Rect(Screen.width/2-Screen.width/16,Screen.height/2-Screen.height/2.5f,Screen.width/8,Screen.height/14),Resolucoes);
		 GUI.DrawTexture(new Rect(Screen.width/2+Screen.width/5,Screen.height/2-Screen.height/2.5f,Screen.width/8,Screen.height/14),ModoJanelaOuTelaCheia);
		 GUI.DrawTexture(new Rect(Screen.width/2+Screen.width/5,Screen.height/2-Screen.height/10,Screen.width/8,Screen.height/14),Volume);
		 //
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/2.2f,Screen.height/2+Screen.height/2.5f,Screen.width/8,Screen.height/14),"VOLTAR")){
			 EstaNoMenuPrincipal = true;
			 EstaNosGraficos = false;
		 }
		 //QUALIDADES
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/3,Screen.height/2-Screen.height/4,Screen.width/8,Screen.height/14),"PESSIMO")){
			 QualitySettings.SetQualityLevel(0);
			 qualidadeGrafica = 0;
		 }
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/3,Screen.height/2-Screen.height/6,Screen.width/8,Screen.height/14),"RUIM")){
			 QualitySettings.SetQualityLevel(1);
			 qualidadeGrafica = 1;
		 }
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/3,Screen.height/2-Screen.height/12,Screen.width/8,Screen.height/14),"SIMPLES")){
			 QualitySettings.SetQualityLevel(2);
			 qualidadeGrafica = 2;
		 }
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/3,Screen.height/2,Screen.width/8,Screen.height/14),"BOM")){
			 QualitySettings.SetQualityLevel(3);
			 qualidadeGrafica = 3;
		 }
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/3,Screen.height/2+Screen.height/12,Screen.width/8,Screen.height/14),"OTIMO")){
			 QualitySettings.SetQualityLevel(4);
			 qualidadeGrafica = 4;
		 }
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/3,Screen.height/2+Screen.height/6,Screen.width/8,Screen.height/14),"FANTASTICO")){
			 QualitySettings.SetQualityLevel(5);
			 qualidadeGrafica = 5;
		 }
		 //RESOLUCOES
		 ResolucaoLargura = GUI.TextField(new Rect(Screen.width/2-Screen.width/16,Screen.height/2-Screen.height/4,Screen.width/8,Screen.height/14),ResolucaoLargura);
		 ResolucaoAltura = GUI.TextField(new Rect(Screen.width/2-Screen.width/16,Screen.height/2-Screen.height/6,Screen.width/8,Screen.height/14),ResolucaoAltura);
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/16,Screen.height/2-Screen.height/12,Screen.width/8,Screen.height/14),"Aplicar")){
			Screen.SetResolution(int.Parse (ResolucaoLargura),int.Parse (ResolucaoAltura),true);
		 }
		 //TELACHEIA
		 if(GUI.Button(new Rect(Screen.width/2+Screen.width/5,Screen.height/2-Screen.height/4,Screen.width/8,Screen.height/14),"Trocar")){
			Screen.fullScreen = !Screen.fullScreen;
		 }
		 //VOLUME
		 VOLUME = GUI.HorizontalSlider(new Rect(Screen.width/2+Screen.width/5,Screen.height/2,Screen.width/8,Screen.height/14),VOLUME,0,1);
		 //SALVAR PREFERENCIAS
		 if(GUI.Button(new Rect(Screen.width/2+Screen.width/5,Screen.height/2+Screen.height/3,Screen.width/8,Screen.height/14),"SALVAR PREF.")){
			 PlayerPrefs.SetFloat("VOLUME",VOLUME);
			 PlayerPrefs.SetInt("qualidadeGrafica",qualidadeGrafica);
		 }
	 } 
	 //=============================== SE ESTA NA PARTE DOS CREDITOS DO MENU ===================//
	 if (EstaNosCreditos == true) {
		 GUI.skin.button = EstiloDosBotoesGraficos;
		 GUI.DrawTexture(new Rect(Screen.width/2-Screen.width/2,Screen.height/2-Screen.height/2,Screen.width,Screen.height),TexturaCreditos);
		 if(GUI.Button (new Rect(Screen.width/2-Screen.width/2.2f,Screen.height/2+Screen.height/2.5f,Screen.width/8,Screen.height/14),"VOLTAR")){
			 EstaNoMenuPrincipal = true;
			 EstaNosCreditos = false;
	 }
	 }
 }*/
 
}