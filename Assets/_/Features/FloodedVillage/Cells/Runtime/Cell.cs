using System.Collections.Generic;
using FloodedVillage.Cells.Runtime.CellEnums;
using UnityEngine;

public abstract class Cell : VerboseBehaviour
{
    public CellObjectEnum m_cellObject = CellObjectEnum.None;
    public CellTypeEnum m_cellType = CellTypeEnum.Empty;
    public WaterStateEnum m_waterState = WaterStateEnum.Dry;

    public List<Cell> m_nearbyCells = new();
    public Sprite m_waterSprite;
    public Sprite m_dirtSprite;

    public SpriteRenderer m_bgRenderer;
    public SpriteRenderer m_fgRenderer;
    public SpriteRenderer m_waterRenderer;

    private void Awake()
    {
        m_bgRenderer.sprite = m_dirtSprite;
        m_waterRenderer.sprite = m_waterSprite;
        m_waterRenderer.enabled = false;
    }

    public abstract void Flood(int remainingDepht);
    protected void BaseFlood(int remainingDepht)
    {
        if (remainingDepht > 0)
        {
            if (m_waterState == WaterStateEnum.Wet)
            {
                for (int i = 0; i < m_nearbyCells.Count; i++)
                {
                    if (m_cellType == CellTypeEnum.Empty)
                    {
                        m_nearbyCells[i].OnFlooded(remainingDepht);
                    }
                }
            }
        }
        else
        {
            Debug.Log("Reached max depth, breaking out");
        }
    }
    public abstract void OnCellClicked();
    public abstract void OnFlooded(int remainingDepth);
    protected void BaseOnFlooded(int remainingDepth)
    {
        if (remainingDepth > 0)
        {
            if (m_cellType == CellTypeEnum.Empty && m_waterState != WaterStateEnum.Wet)
            {
                m_waterState = WaterStateEnum.Wet;
                m_waterRenderer.enabled = true;
                Flood(remainingDepth - 1);
            }
        }
        else
        {
            Debug.Log("Reached max depth, breaking out");
        }
    }
    public abstract bool WinningState();
    public abstract bool LosingState();
}
