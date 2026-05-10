using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartObjective : MonoBehaviour
{
    public ObjectiveUI objectiveUI;

    void Start()
    {
        objectiveUI.ShowObjective("Va voir le marchand", 5f);
    }
}
