using System.Collections.Generic;
using UnityEngine;

public abstract class Cell : VerboseBehaviour
{
    public EnumCellObject m_cellObject = EnumCellObject.None;
    public EnumCellType m_cellType = EnumCellType.Empty;
    public EnumWaterState m_waterState = EnumWaterState.Dry;

    public List<Cell> m_nearbyCells = new List<Cell>();
    public Sprite m_waterSprite;
    public Sprite m_dirtSprite;

    public SpriteRenderer m_bgRenderer;
    public SpriteRenderer m_fgRenderer;
    public SpriteRenderer m_waterRenderer;

    public EnumWaterState WaterState { get => m_waterState; }

    private void Awake()
    {
        m_bgRenderer.sprite = m_dirtSprite;
        m_waterRenderer.sprite = m_waterSprite;
        m_waterRenderer.enabled = false;
    }

    protected void Flood()
    {
        if (m_waterState == EnumWaterState.Wet)
        {
            for (int i = 0; i <= m_nearbyCells.Count; i++)
            {
                if (m_cellType == EnumCellType.Empty)
                {
                    m_nearbyCells[i].OnFlooded();
                }
            }
        }
    }

    public abstract void OnCellClicked();
    public abstract void OnFlooded();
    public abstract bool WinningState();
    public abstract bool LosingState();
}
