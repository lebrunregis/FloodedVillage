using UnityEngine;

public class StoneCell : Cell
{
    public Sprite m_stoneSprite;

    private void Awake()
    {
        m_bgLayer.sprite = m_dirtSprite;
        m_fgLayer.sprite = m_stoneSprite;
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
