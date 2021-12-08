using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private ResourceBank _resourceBank;
    public int Resources;

    public static Game Intance;

    private void Awake()
    {
        Intance = this;
        Resources = 10;
    }
}

public class Sample : MonoBehaviour
{
    private Game _game;

    private void Awake()
    {
        _game = Game.Intance;
    }

    private void DoSomething()
    {

    }
}
