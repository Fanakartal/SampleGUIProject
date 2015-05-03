using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIButtonController : MonoBehaviour {

    public static bool panelTurned;

    public GameObject slider;
    
    //public GameObject PlayGame;

    void Awake()
    {
        //_SaveLoad.Load();
        //slider.GetComponent<Slider>().value = _Game.current.score;
    }
    
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
