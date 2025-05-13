using System.Collections.Generic;
using UnityEngine;

public abstract class Cell : VerboseBehaviour
{
    protected EnumCellObject m_cellObject = EnumCellObject.None;
    protected EnumCellType m_cellType = EnumCellType.Empty;
    protected EnumWaterState m_waterState = EnumWaterState.Dry;

    public List<Cell> m_nearbyCells = new List<Cell>();
    public static Sprite m_waterSprite;
    public static Sprite m_dirtSprite;

    public SpriteRenderer m_bgLayer;
    public SpriteRenderer m_fgLayer;
    public SpriteRenderer m_waterLayer;

    public EnumWaterState WaterState { get => m_waterState; }

    private void Awake()
    {
        m_bgLayer.sprite = m_dirtSprite;
    }

    private void OnMouseDown()
    {
        OnCellClicked();
    }

    protected void Flood()
    {
        foreach (var cell in m_nearbyCells)
        {
            cell.OnFlooded();
        }
    }

    public abstract void OnCellClicked();
    public abstract void OnFlooded();
    public abstract bool WinningState();
    public abstract bool LosingState();
}
