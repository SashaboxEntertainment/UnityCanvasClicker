using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceVisual : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] private ResourceType _resourceType;

    [SerializeField] private TextMeshProUGUI _humansText;
    [SerializeField] private TextMeshProUGUI _foodText;
    [SerializeField] private TextMeshProUGUI _woodText;
    [SerializeField] private TextMeshProUGUI _goldText;
    [SerializeField] private TextMeshProUGUI _stoneText;

    public void UpdateText()
	{
        if (_resourceType == ResourceType.HUMANS)
        {
            _humansText.text = $"Humans: {_game.GameConfig.Humans.ToString()}";
        }

        if (_resourceType == ResourceType.FOOD)
        {
            _foodText.text = $"Food: {_game.GameConfig.Food.ToString()}";
        }
        
        if (_resourceType == ResourceType.WOOD)
        {
            _woodText.text = $"Wood: {_game.GameConfig.Wood.ToString()}";
        }
        
        if (_resourceType == ResourceType.GOLD)
        {
            _goldText.text = $"Gold: {_game.GameConfig.Gold.ToString()}";
        }
        
        if (_resourceType == ResourceType.STONE)
        {
            _stoneText.text = $"Stone: {_game.GameConfig.Stone.ToString()}";
        }
    }
}
