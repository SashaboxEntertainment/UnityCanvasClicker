using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    private Dictionary<ResourceType, int> _resource;

    private void OnEnable()
    {
        _resource = new Dictionary<ResourceType, int>()
        {
            [ResourceType.FOOD] = Game.Intance.GameConfig.Food,
            [ResourceType.HUMANS] = Game.Intance.GameConfig.Humans,
            [ResourceType.WOOD] = Game.Intance.GameConfig.Wood,
            [ResourceType.STONE] = Game.Intance.GameConfig.Stone,
            [ResourceType.GOLD] = Game.Intance.GameConfig.Gold,
        };

        if (!_resource.ContainsKey(ResourceType.FOOD) ||
            !_resource.ContainsKey(ResourceType.HUMANS) ||
            !_resource.ContainsKey(ResourceType.WOOD) ||
            !_resource.ContainsKey(ResourceType.STONE) ||
            !_resource.ContainsKey(ResourceType.GOLD))
        {

        }
    }

    public void ChangeResource(ResourceType r, int v)
    {
        if (!_resource.ContainsKey(r))
            throw new InvalidDataException();

        _resource[r] += v;
    }

    public int GetResource(ResourceType r)
    {
        if (!_resource.ContainsKey(r))
            throw new InvalidDataException();

        return _resource[r];
    }
}
