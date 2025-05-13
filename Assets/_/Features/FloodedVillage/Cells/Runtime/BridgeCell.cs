using UnityEngine;

public class BridgeCell : Cell
{
    public Sprite m_bridgeSprite;
    private void Awake()
    {
        m_bgLayer.sprite = m_dirtSprite;
        m_fgLayer.sprite = m_bridgeSprite;
    }
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
