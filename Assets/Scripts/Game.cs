using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameConfig GameConfig;
    private int _humans;
    private int _food;
    private int _wood;
    private int _gold;
    private int _stone;

    public int Humans;
    public int Food;
    public int Wood;
    public int Gold;
    public int Stone;
    public static Game Intance;

    private void Awake()
    {
        Intance = this;
        _humans = GameConfig.Humans;
        _food = GameConfig.Food;
        _wood = GameConfig.Wood;
        _gold = GameConfig.Gold;
        _stone = GameConfig.Stone;
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
