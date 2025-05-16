using System.Collections.Generic;
using UnityEngine;

public class FloodedMap : MonoBehaviour
{
    public GameObject none;
    public GameObject bridge;
    public GameObject empty;
    public GameObject seeds;
    public GameObject sand;
    public GameObject stone;
    public GameObject villager;
    public GameObject water;
    public GameObject zombie;
    public GameObject[] map;
    public int width;
    public int height;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        GenerateMap();
        ConnectCells();
    }

    private void ConnectCells()
    {
        for (int i = 0; i < map.Length; i++)
        {
            List<int> list = GetNeighborsList(i, false);
            foreach (int j in list)
            {
                Debug.Log(i + " " + j);
                map[i].GetComponent<Cell>().m_nearbyCells.Add(map[j].GetComponent<Cell>());
            }
        }
    }

    private List<int> GetNeighborsList(int i, bool diagonals)
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

    private void GenerateMap()
    {
        // map = new GameObject[width * height];
        for (int i = 0; i < map.Length; i++)
        {
            GameObject go = Instantiate(map[i]);
            go.transform.position = new Vector3(i % width, i / width, 0);
            map[i] = go;
            go.SetActive(true);
        }
    }
}
