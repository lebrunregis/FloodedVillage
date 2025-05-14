using UnityEngine;

public class VerboseBehaviour : MonoBehaviour
{
    #region Debug
    public bool m_isVerbose = true;

    protected void Log(string msg)
    {
        if (m_isVerbose)
            Debug.Log(msg, this);
    }
    #endregion
}
