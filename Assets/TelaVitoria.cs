using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class TelaVitoria : MonoBehaviour {

    public Button BotaoJogar, BotaoVoltar;

    public string nomeCenaJogo = "scene";
    public string nomeCenaMenu = "MENU";
    private string nomeDaCena;


    // Use this for initialization
    void Start()
    {
        nomeDaCena = SceneManager.GetActiveScene().name;
        Cursor.visible = true;
        Time.timeScale = 1;

        BotaoJogar.onClick = new Button.ButtonClickedEvent();
        BotaoVoltar.onClick = new Button.ButtonClickedEvent();

        BotaoJogar.onClick.AddListener(() => Jogar());
        BotaoVoltar.onClick.AddListener(() => Voltar());
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != nomeDaCena)
        {
            //AudioListener.volume = VOLUME;
            Destroy(gameObject);
        }
    }

    private void Jogar()
    {
        SceneManager.LoadScene(nomeCenaJogo);
    }

    private void Voltar()
    {
        SceneManager.LoadScene(nomeCenaMenu);
    }
}
