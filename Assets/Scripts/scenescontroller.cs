using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenescontroller : MonoBehaviour
{

    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void cargarjuego()
    {
        SceneManager.LoadScene("Juego");

    }
    public void backMenu()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void LoadCreditos()
    {
        SceneManager.LoadScene("Creditos");

    }

    public void Quit()
    {
        Application.Quit();

    }
}
