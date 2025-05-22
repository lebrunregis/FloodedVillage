using FloodedVillage.Cells.Runtime.CellEnums;
using UnityEngine;

public class SeedCell : Cell
{
    public Sprite seeds;
    public Sprite tree;

    private void Awake()
    {
        m_cellObject = CellObjectEnum.Tree;
        m_cellType = CellTypeEnum.Dirt;
        m_waterState = WaterStateEnum.Dry;
        m_fgRenderer.sprite = seeds;
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
        switch (m_waterState)
        {
            case WaterStateEnum.Dry:
                return false;
            case WaterStateEnum.Wet:
                return true;
            default:
                return false;
        }
    }

    public override void Flood(int remainingDepht)
    {
        base.BaseFlood(remainingDepht);
    }

    public override void OnFlooded(int remainingDepth)


    {
        m_waterState = WaterStateEnum.Wet;
        m_fgRenderer.sprite = tree;
        base.BaseOnFlooded(remainingDepth);
    }
}
