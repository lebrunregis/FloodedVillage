using UnityEngine;

public class BridgeCell : Cell
{
    public Sprite m_bridgesprite;
    public override bool LosingState()
    {
        return false;
    }

    public override void OnCellClicked()
    {
    }

    public override void OnFlooded()
    {
        Flood();
    }

    public override bool WinningState()
    {
        return true;
    }
}
