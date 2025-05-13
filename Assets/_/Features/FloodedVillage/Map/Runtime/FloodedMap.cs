using UnityEngine;

public class FloodedMap : MonoBehaviour
{
    public Sprite none;
    public Sprite bridge;
    public Sprite crops;
    public Sprite empty;
    public Sprite seeds;
    public Sprite stone;
    public Sprite villager;
    public Sprite villager_drowned;
    public Sprite water;
    public Sprite zombie;
    public Sprite zombie_drowned;
    public GameObject[] bg;
    public GameObject[] fg;
    public int width;
    public int height;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        GenerateBG();
        GenerateFG();
    }

    private void GenerateBG()
    {
        bg = new GameObject[width * height];
        for (int i = 0; i < bg.Length; i++)
        {
            GameObject go = new GameObject();
            SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
            sr.sprite = none;
            go.transform.position = new Vector3(i % width, i / width, 0);
            bg[i] = go;
        }
    }

    private void GenerateFG()
    {
        fg = new GameObject[width * height];
        for (int i = 0; i < fg.Length; i++)
        {
            GameObject go = new GameObject();
            SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
            go.transform.position = new Vector3(i % width, i / width, 0);
            fg[i] = go;
        }
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
