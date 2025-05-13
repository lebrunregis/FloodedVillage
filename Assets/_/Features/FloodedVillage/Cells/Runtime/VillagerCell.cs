using UnityEngine;

public class VillagerCell : Cell
{
    public Sprite m_villager;
    public Sprite m_deadVillager;

    private void Awake()
    {
        m_bgLayer.sprite = m_dirtSprite;
        m_fgLayer.sprite = m_villager;
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
