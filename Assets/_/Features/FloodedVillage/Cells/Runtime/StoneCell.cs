using UnityEngine;

public class StoneCell : Cell
{
    public Sprite m_stoneSprite;

    private void Awake()
    {
        m_cellObject = EnumCellObject.None;
        m_cellType = EnumCellType.Stone;
        m_waterState = EnumWaterState.Dry;
        m_bgRenderer.sprite = m_dirtSprite;
        m_fgRenderer.sprite = m_stoneSprite;
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


    }

    public override bool WinningState()
    {
        return true;
    }
}
