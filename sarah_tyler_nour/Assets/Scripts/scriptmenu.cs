using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class scriptmenu : MonoBehaviour

{

    void Start()

    {

    }


    void Update()
    {

    }
    public void quitterPartie()
    {
        Application.Quit();
    }

    public void jouer()
    {
        SceneManager.LoadScene(1);
    }

}

