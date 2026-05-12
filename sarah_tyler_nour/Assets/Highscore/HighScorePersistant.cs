using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScorePersistant : MonoBehaviour
{
    public TextMeshProUGUI textePointage;

    private int _pointageActuel = 0;

    void Start()
    {
        _pointageActuel = 0;
        textePointage.text = _pointageActuel.ToString();
    }

    public void OnChangerPointage(int nouvellePointage)
    {
        _pointageActuel = nouvellePointage;
        textePointage.text = _pointageActuel.ToString();
    }
}