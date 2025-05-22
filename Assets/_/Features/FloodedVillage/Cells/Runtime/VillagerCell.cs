using FloodedVillage.Cells.Runtime.CellEnums;
using UnityEngine;

public class VillagerCell : Cell
{
    public Sprite m_villager;
    public Sprite m_deadVillager;

    private void Awake()
    {
        m_cellObject = CellObjectEnum.Villager;
        m_cellType = CellTypeEnum.Empty;
        m_waterState = WaterStateEnum.Dry;
        m_bgRenderer.sprite = m_dirtSprite;
        m_fgRenderer.sprite = m_villager;
        m_waterRenderer.sprite = m_waterSprite;
    }

    public override bool LosingState()
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

    public override void OnCellClicked()
    {
    }

    public override void OnFlooded(int remainingDepth)
    {
        Debug.Log("Villager died");
        m_fgRenderer.sprite = m_deadVillager;
        base.BaseOnFlooded(remainingDepth);
    }

    public override bool WinningState()
    {
        switch (m_waterState)
        {
            case WaterStateEnum.Dry:
                return true;
            case WaterStateEnum.Wet:
                return false;
            default:
                return false;
        }
    }

    public override void Flood(int remainingDepht)
    {
        base.BaseFlood(remainingDepht);
    }

}
