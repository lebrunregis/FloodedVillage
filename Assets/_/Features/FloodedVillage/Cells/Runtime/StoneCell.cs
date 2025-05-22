using FloodedVillage.Cells.Runtime.CellEnums;
using UnityEngine;

public class StoneCell : Cell
{
    public Sprite m_stoneSprite;

    private void Awake()
    {
        m_cellObject = CellObjectEnum.None;
        m_cellType = CellTypeEnum.Stone;
        m_waterState = WaterStateEnum.Dry;
        m_bgRenderer.sprite = m_dirtSprite;
        m_fgRenderer.sprite = m_stoneSprite;
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

    }

    public override void OnFlooded(int remainingDepth)
    {

    }
}
