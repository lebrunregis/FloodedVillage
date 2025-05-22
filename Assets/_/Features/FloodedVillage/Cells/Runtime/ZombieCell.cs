using FloodedVillage.Cells.Runtime.CellEnums;
using UnityEngine;

public class ZombieCell : Cell
{
    public Sprite m_zombie;
    public Sprite m_drownedZombie;

    private void Awake()
    {
        m_cellObject = CellObjectEnum.Zombie;
        m_cellType = CellTypeEnum.Empty;
        m_waterState = WaterStateEnum.Dry;
        m_bgRenderer.sprite = m_dirtSprite;
        m_fgRenderer.sprite = m_zombie;
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

        m_fgRenderer.sprite = m_drownedZombie;
        base.BaseOnFlooded(remainingDepth);
    }
}
