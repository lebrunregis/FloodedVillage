using UnityEngine;

[RequireComponent(typeof(MapBuilder))]
public class MapLoader : MonoBehaviour
{
    private MapBuilder m_MapBuilder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
    }

    private void OnEnable()
    {

    }

    private void Awake()
    {

        m_MapBuilder = GetComponent<MapBuilder>();
    }

    public void LoadLevel(MapScriptableObject level)
    {
        if (level != null)
        {
            m_MapBuilder.BuildMap(level);
        }
        else
        {
            Debug.Log("Map not found!");
        }
    }
}
