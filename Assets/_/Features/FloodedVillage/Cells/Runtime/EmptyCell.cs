public class EmptyCell : Cell
{
    public override void Flood(int remainingDepht)
    {
        base.BaseFlood(remainingDepht);
    }

    public override bool LosingState()
    {
        return false;
    }

    public override void OnCellClicked()
    {
    }


    public override void OnFlooded(int remainingDepth)
    {
        base.BaseOnFlooded(remainingDepth);
    }

    public override bool WinningState()
    {
        return true;
    }
}
