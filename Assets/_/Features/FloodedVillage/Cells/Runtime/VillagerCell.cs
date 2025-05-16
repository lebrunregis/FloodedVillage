using UnityEngine;

public class VillagerCell : Cell
{
    public Sprite m_villager;
    public Sprite m_deadVillager;

    private void Awake()
    {
        m_cellObject = EnumCellObject.Villager;
        m_cellType = EnumCellType.Empty;
        m_waterState = EnumWaterState.Dry;
        m_bgRenderer.sprite = m_dirtSprite;
        m_fgRenderer.sprite = m_villager;
        m_waterRenderer.sprite = m_waterSprite;
    }

    public override bool LosingState()
    {
        switch (m_waterState)
        {
            case EnumWaterState.Dry:
                return false;
            case EnumWaterState.Wet:
                return true;
            default:
                return false;
        }
    }

    public override void OnCellClicked()
    {
    }

    public override void OnFlooded()
    {
        m_waterState = EnumWaterState.Wet;
        m_waterRenderer.enabled = true;
        m_fgRenderer.sprite = m_deadVillager;
        Flood();
    }

    public override bool WinningState()
    {
        switch (m_waterState)
        {
            case EnumWaterState.Dry:
                return true;
            case EnumWaterState.Wet:
                return false;
            default:
                return false;
        }
    }
}
