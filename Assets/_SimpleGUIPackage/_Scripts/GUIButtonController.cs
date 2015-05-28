using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIButtonController : MonoBehaviour 
{    
    
    public void GetNextLevel(int nextScene)
    {
        Application.LoadLevel(nextScene);
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
