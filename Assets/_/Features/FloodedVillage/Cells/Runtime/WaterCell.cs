public class WaterCell : Cell
{

    private void Awake()
    {
        m_bgLayer.sprite = m_dirtSprite;
        m_waterLayer.sprite = m_waterSprite;
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
