using UnityEngine;

public class VerboseBehaviour : MonoBehaviour
{
    #region Debug
    private bool m_isVerbose;

    protected void Log(string msg)
    {
        if (m_isVerbose)
            Debug.Log(msg, this);
    }
    #endregion
}
