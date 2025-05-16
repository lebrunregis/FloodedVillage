using UnityEngine;

public class BridgeCell : Cell
{
    public Sprite m_bridgeSprite;
    private void Awake()
    {
        m_cellObject = EnumCellObject.Bridge;
        m_cellType = EnumCellType.Empty;
        m_waterState = EnumWaterState.Dry;
        m_bgRenderer.sprite = m_dirtSprite;
        m_fgRenderer.sprite = m_bridgeSprite;
        m_waterRenderer.sprite = m_waterSprite;
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
        m_waterState = EnumWaterState.Wet;
        m_waterRenderer.enabled = true;
        Flood();
    }

    public override bool WinningState()
    {
        return true;
    }
}
