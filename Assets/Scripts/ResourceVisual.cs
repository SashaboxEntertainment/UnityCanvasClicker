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
        _humansText.text = $"Humans: {_game.Resources.ToString()}";
        _foodText.text = $"Food: {_game.Resources.ToString()}";
        _woodText.text = $"Wood: {_game.Resources.ToString()}";
        _goldText.text = $"Gold: {_game.Resources.ToString()}";
        _stoneText.text = $"Stone: {_game.Resources.ToString()}";
    }
}
