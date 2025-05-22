using UnityEngine;

public class FloodedMap : MonoBehaviour
{

    public GameObject[] map;
    internal void setCells(GameObject[] cells)
    {
        map = cells;
    }

    public void Clear()
    {
        for (int i = 0; i < map.Length; i++)
        {
            Destroy(map[i]);
            map = null;
        }
    }
}
