using UnityEngine;

public class SandCell : Cell
{
    public Sprite m_sandSprite;

    public void Awake()
    {
        m_cellObject = EnumCellObject.None;
        m_cellType = EnumCellType.Sand;
        m_waterState = EnumWaterState.Dry;
        m_bgRenderer.sprite = m_dirtSprite;
        m_fgRenderer.sprite = m_sandSprite;
        m_waterRenderer.sprite = m_waterSprite;
    }
    public override bool LosingState()
    {
        return false;
    }

    public override void OnCellClicked()
    {
        if (m_cellType == EnumCellType.Sand)
        {
            DestroySand();
            NearbyWaterCheck();
        }
    }

    private void DestroySand()
    {

        m_fgRenderer.enabled = false;
        m_cellType = EnumCellType.Empty;
    }

    public void OnMouseDown()
    {
        OnCellClicked();
    }

    public override void OnFlooded()
    {
        Debug.Log("OnFlooded");
        if (m_waterState != EnumWaterState.Wet)
        {
            Debug.Log("Replacing sand by water");
            m_waterState = EnumWaterState.Wet;
            m_waterRenderer.enabled = true;
            Flood();
        }
    }

    public override bool WinningState()
    {
        return true;
    }

    private void NearbyWaterCheck()
    {
        foreach (Cell cell in m_nearbyCells)
        {
            switch (cell.WaterState)
            {
                case EnumWaterState.Wet:
                    Debug.Log("Water detected");
                    OnFlooded();
                    break;
                case EnumWaterState.Dry:
                    break;

            }
        }
    }
}
