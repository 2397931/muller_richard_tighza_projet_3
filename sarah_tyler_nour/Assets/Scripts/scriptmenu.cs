using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class scriptmenu : MonoBehaviour

{

    public void Commencer()
    {
        SceneManager.LoadScene(1);
    }
    public void quitterPartie()
    {
        Application.Quit();
    }

    

}

