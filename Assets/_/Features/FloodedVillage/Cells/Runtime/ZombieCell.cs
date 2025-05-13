using UnityEngine;

public class ZombieCell : Cell
{
    public Sprite m_zombie;
    public Sprite m_drownedZombie;
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
                return false;
            case EnumWaterState.Wet:
                return true;
            default:
                return false;
        }
    }
}
