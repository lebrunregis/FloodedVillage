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

    // Update is called once per frame
    private void Update()
    {

    }
}
