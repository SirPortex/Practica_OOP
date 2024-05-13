using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Character character;

    public static GameManager instance;
    
    private string _gameName;

    //public Human capitan;

    private void Awake()
    {

        // SINGLETON
        if (!instance) // si instance no tiene informacion
        {
            instance = this; // instance se asigna a este objeto
            DontDestroyOnLoad(gameObject); // se indica que este obj no se destruya con la carga de escenas
        }
        else // si instance tiene info
        {
            Destroy(gameObject); // se destruye el gameObject, para que no haya dos o mas gms en el juego
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // callback ---> funcion que se va a llamar en el onclick() de los botones
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Debug.Log("Exit!!");
        Application.Quit();
    }

    //setter
    public void SetName(string name)
    {
        _gameName = name;
    }

    //getter
    public string GetName()
    {
        return _gameName;
    }

    public void SelectCharacter(int value)
    {
        if (value == 1)
        {
            character = new Cowboy(_gameName);
        }
        else if (value == 2)
        {
            character = new Wizard(_gameName, 1.5f);
        }
    }
}

