public class WaterCell : Cell
{

    private void Awake()
    {
        m_cellObject = EnumCellObject.None;
        m_cellType = EnumCellType.Empty;
        m_waterState = EnumWaterState.Wet;
        m_bgRenderer.sprite = m_dirtSprite;
        m_waterRenderer.sprite = m_waterSprite;
        m_waterState = EnumWaterState.Wet;
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
