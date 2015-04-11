using UnityEngine;
using System.Collections;

public class GUIButtonController : MonoBehaviour {

    public static bool panelTurned;
    
    //public GameObject PlayGame;
    
    public void GetNextLevel(int nextScene)
    {
        Application.LoadLevel(nextScene);
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
        Debug.Log(Application.loadedLevel);
    }

    public void OpenIngameSettings()
    {
        
    }
}
