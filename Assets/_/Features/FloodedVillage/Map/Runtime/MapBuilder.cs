using System.Collections.Generic;
using Flooded.Map.Runtime.Enums;
using UnityEngine;

[RequireComponent(typeof(FloodedMap))]
public class MapBuilder : MonoBehaviour
{
    public FloodedMap map;
    public GameObject none;
    public GameObject bridge;
    public GameObject empty;
    public GameObject seeds;
    public GameObject sand;
    public GameObject stone;
    public GameObject villager;
    public GameObject water;
    public GameObject zombie;
    public GameObject ice;
    private void OnEnable()
    {
        map = GetComponent<FloodedMap>();
    }

    private void ConnectCells(GameObject[] map, int width, int height)
    {
        for (int i = 0; i < map.Length; i++)
        {
            List<int> list = GetNeighborsList(i, width, height);
            foreach (int j in list)
            {
                Debug.Log(i + " " + j);
                map[i].GetComponent<Cell>().m_nearbyCells.Add(map[j].GetComponent<Cell>());
            }
        }
    }

    private List<int> GetNeighborsList(int i, int width, int height, bool diagonals = false)
    {
        List<int> neighbors = new List<int>();
        int u = i - width;
        int d = i + width;
        int l = i - 1;
        int r = i + 1;

        Debug.Log(u + " " + d + " " + l + " " + r);

        if (u >= 0)
        {
            neighbors.Add(u);
        }
        if (d < width * height)
        {
            neighbors.Add(d);
        }

        if (l >= 0 && l / width == i / width)
        {
            neighbors.Add(l);
        }

        if (r < width * height && r / width == i / width)
        {
            neighbors.Add(r);
        }

        return neighbors;

    }

    private void GenerateMap(MapScriptableObject mapSO, GameObject[] map)
    {
        // map = new GameObject[width * height];
        for (int i = 0; i < map.Length; i++)
        {
            GameObject go = GetMappedCellInstance(mapSO.map[i]);
            go.transform.position = new Vector3(i % mapSO.Width, i / mapSO.Width, 0);
            map[i] = go;
            go.SetActive(true);
        }
    }

    internal void BuildMap(MapScriptableObject mapSO)
    {
        if (mapSO.IsValid())
        {
            GameObject[] map = new GameObject[mapSO.map.Length];
            GenerateMap(mapSO, map);
            ConnectCells(map, mapSO.Width, mapSO.Height());
            this.map.setCells(map);
        }
        else
        {
            Debug.Log("Map is invalid! Check your ScriptableObject!", this);
        }
    }

    private GameObject GetMappedCellInstance(CellTypeEnum cellType)
    {
        GameObject go = null;
        switch (cellType)
        {

            case CellTypeEnum.Empty:
                go = Instantiate(empty);
                break;
            case CellTypeEnum.Dirt:
                go = Instantiate(empty);
                break;
            case CellTypeEnum.Sand:
                go = Instantiate(sand);
                break;
            case CellTypeEnum.Rock:
                go = Instantiate(stone);
                break;
            case CellTypeEnum.Villager:
                go = Instantiate(villager);
                break;
            case CellTypeEnum.Water:
                go = Instantiate(water);
                break;
            case CellTypeEnum.Zombie:
                go = Instantiate(zombie);
                break;
            case CellTypeEnum.Ice:
                go = Instantiate(ice);
                break;
            case CellTypeEnum.Bridge:
                go = Instantiate(bridge);
                break;
            default:
                go = Instantiate(empty);
                Debug.Log("Missing prefab", this);
                break;
        }
        return go;
    }
}
