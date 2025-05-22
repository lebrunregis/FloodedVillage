using UnityEngine;


public class ScoreUi : MonoBehaviour
{
    public SyncedIntValueListener scoreListener;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int UIScore = 0;

    private void OnEnable()
    {
        scoreListener.enabled = true;
    }

    private void OnDisable()
    {
        scoreListener.enabled = false;
    }

    public void UpdateCurrentScore(int score)
    {
        UIScore = score;
    }
}
