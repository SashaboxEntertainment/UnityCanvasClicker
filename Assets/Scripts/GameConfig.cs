using UnityEngine;

[CreateAssetMenu(menuName = "SO/new Game config", fileName = "GameConfig")]
public class GameConfig : ScriptableObject
{
    [Range(0, 100)]
    public int Humans;
    [Range(0, 100)]
    public int Food;
    [Range(0, 100)]
    public int Wood;
    public int Gold;
    public int Stone;
}
