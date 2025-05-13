public class StoneCell : Cell
{
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
