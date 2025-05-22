using FloodedVillage.Cells.Runtime.CellEnums;
using UnityEngine;

public class SandCell : Cell
{
    public Sprite m_sandSprite;

    public void Awake()
    {
        m_cellObject = CellObjectEnum.None;
        m_cellType = CellTypeEnum.Sand;
        m_waterState = WaterStateEnum.Dry;
        m_bgRenderer.sprite = m_dirtSprite;
        m_fgRenderer.sprite = m_sandSprite;
        m_waterRenderer.sprite = m_waterSprite;
    }
    public override bool LosingState()
    {
        return false;
    }

    public override void OnCellClicked()
    {
        if (m_cellType == CellTypeEnum.Sand)
        {
            DestroySand();
            NearbyWaterCheck();
        }
    }

    private void DestroySand()
    {

        m_fgRenderer.enabled = false;
        m_cellType = CellTypeEnum.Empty;
    }

    public void OnMouseDown()
    {
        OnCellClicked();
    }

    public override bool WinningState()
    {
        return true;
    }

    private void NearbyWaterCheck()
    {
        foreach (Cell cell in m_nearbyCells)
        {
            switch (cell.m_waterState)
            {
                case WaterStateEnum.Wet:
                    Debug.Log("Water detected");
                    OnFlooded(25);
                    break;
                case WaterStateEnum.Dry:
                    break;

            }
        }
    }

    public override void Flood(int remainingDepht)
    {
        base.BaseFlood(remainingDepht);
    }

    public override void OnFlooded(int remainingDepth)
    {
        Debug.Log("OnFlooded");
        if (m_cellType == CellTypeEnum.Empty)
        {
            base.BaseOnFlooded(remainingDepth);
        }
    }
}
