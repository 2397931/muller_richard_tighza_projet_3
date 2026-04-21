using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text montantATrouver;
    public TMP_Text separateur;
    public TMP_Text montantTrouver;
    public joueurInteractions joueur;

    void Start()
    {
        separateur.text = "/";
        montantATrouver.text = joueur.objectifArgent.ToString();
    }

    void Update()
    {
        montantTrouver.text = joueur.argent.ToString();
    }
}

