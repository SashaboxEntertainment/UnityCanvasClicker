using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceVisual : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] TextMeshProUGUI _humansText;
    [SerializeField] TextMeshProUGUI _foodText;
    [SerializeField] TextMeshProUGUI _woodText;
    [SerializeField] TextMeshProUGUI _goldText;
    [SerializeField] TextMeshProUGUI _stoneText;

    public void UpdateText()
	{
        _humansText.text = $"Humans: {_game.Humans.ToString()}";
        _foodText.text = $"Food: {_game.Food.ToString()}";
        _woodText.text = $"Wood: {_game.Wood.ToString()}";
        _goldText.text = $"Gold: {_game.Gold.ToString()}";
        _stoneText.text = $"Stone: {_game.Stone.ToString()}";
    }
}
