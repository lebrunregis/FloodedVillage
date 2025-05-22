using FloodedVillage.Cells.Runtime.CellEnums;
using UnityEngine;

public class BridgeCell : Cell
{
    public Sprite m_bridgeSprite;
    private void Awake()
    {
        m_cellObject = CellObjectEnum.Bridge;
        m_cellType = CellTypeEnum.Empty;
        m_waterState = WaterStateEnum.Dry;
        m_bgRenderer.sprite = m_dirtSprite;
        m_fgRenderer.sprite = m_bridgeSprite;
        m_waterRenderer.sprite = m_waterSprite;
    }
    public override bool LosingState()
    {
        return false;
    }

    public override void OnCellClicked()
    {
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
