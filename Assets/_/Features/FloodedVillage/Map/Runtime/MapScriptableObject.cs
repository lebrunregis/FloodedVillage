using Flooded.Map.Runtime.Enums;
using UnityEngine;
[CreateAssetMenu(fileName = "Events", menuName = "FloodedVillage/Map", order = 1)]
public class MapScriptableObject : ScriptableObject
{
    public CellTypeEnum[] map;
    [SerializeField]
    private int width;

    public int Width { get => width; set => width = value; }

    public int Height()
    {
        return map.Length / Width;
    }

    public bool IsValid()
    {
        return map.Length % Width == 0;
    }
}
