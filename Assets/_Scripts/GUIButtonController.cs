using UnityEngine;
using System.Collections;

public class GUIButtonController : MonoBehaviour {

    //public GameObject PlayGame;
    
    public void GetNextLevel(int nextScene)
    {
        Application.LoadLevel(nextScene);
    }
}
