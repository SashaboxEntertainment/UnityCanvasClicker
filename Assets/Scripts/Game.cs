using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameConfig GameConfig;

    public static Game Intance;

    private void Awake()
    {
        Intance = this;
    }
}
