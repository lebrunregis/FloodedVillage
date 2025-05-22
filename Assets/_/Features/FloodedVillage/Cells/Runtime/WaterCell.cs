using FloodedVillage.Cells.Runtime.CellEnums;
using UnityEngine;

public class WaterCell : Cell
{
    public Sprite m_iceSprite;
    private void Awake()
    {
        m_cellObject = CellObjectEnum.None;
        m_cellType = CellTypeEnum.Empty;
        m_waterState = WaterStateEnum.Wet;
        m_bgRenderer.sprite = m_dirtSprite;
        m_waterRenderer.sprite = m_waterSprite;
    }

    public override bool LosingState()
    {
        return false;
    }

    public override void OnCellClicked()
    {
        m_waterState = WaterStateEnum.Ice;
        m_waterRenderer.sprite = m_iceSprite;
    }

    public override bool WinningState()
    {
        return true;
    }

    public override void Flood(int remainingDepht)
    {
        base.BaseFlood(remainingDepht);
    }

    public override void OnFlooded(int remainingDepth)
    {
        base.BaseOnFlooded(remainingDepth);
    }
}
