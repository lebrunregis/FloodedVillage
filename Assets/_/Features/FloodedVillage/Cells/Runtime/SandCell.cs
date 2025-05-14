using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class SandCell : Cell
{
    public Sprite m_sandSprite;

    public void Awake()
    {
        m_bgLayer.sprite = m_dirtSprite;
        m_fgLayer.sprite = m_sandSprite;
    }
    public override bool LosingState()
    {
      return false;
    }

    public override void OnCellClicked()
    {
        DestroySand();
        NearbyWaterCheck();
    }

    private void DestroySand()
    {
        m_fgLayer.enabled = false;
    }

    public void OnMouseDown()
    {
         OnCellClicked();
    }

    public override void OnFlooded()
    {
        if (m_waterState != EnumWaterState.Wet)
        {
        m_waterState = EnumWaterState.Wet;
        m_waterLayer.enabled = true;
        Flood();
        }
    }

    public override bool WinningState()
    {
        return true;
    }

    private void NearbyWaterCheck()
    {
        foreach (var cell in m_nearbyCells)
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
