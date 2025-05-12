using UnityEngine;

public class FloodedMap : MonoBehaviour
{
    public GameObject[] cells;
    public int width;
    public int height;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cells = new GameObject[width * height];
        cells = new GameObject[width * height];
        for (int i = 0; i < cells.Length; i++)
        {
            cells[i] = Instantiate(cells[i], new Vector3(i * 2.0f, i/width, 0), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
