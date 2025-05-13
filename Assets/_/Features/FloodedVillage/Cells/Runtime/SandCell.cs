using UnityEngine;

public class SandCell : Cell
{
    public Sprite m_sandSprite;
    public override bool LosingState()
    {
        throw new System.NotImplementedException();
    }

    public override void OnCellClicked()
    {
        NearbyWaterCheck();
    }

    public override void OnFlooded()
    {
        Flood();
    }

    public override bool WinningState()
    {
        throw new System.NotImplementedException();
    }

    private void NearbyWaterCheck()
    {
        foreach (var cell in m_nearbyCells)
        {
            switch (cell.WaterState)
            {
                case EnumWaterState.Wet:
                    OnFlooded();
                    break;
                case EnumWaterState.Dry:
                    break;

            }
        }
    }
}
