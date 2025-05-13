using UnityEngine;

public class SeedCell : Cell
{
    public Sprite seeds;
    public Sprite tree;

    private void Awake()
    {
        m_cellObject = EnumCellObject.Tree;
        m_cellType = EnumCellType.Dirt;
        m_waterState = EnumWaterState.Dry;
        m_fgLayer.sprite = seeds;
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
        m_fgLayer.sprite = tree;
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
