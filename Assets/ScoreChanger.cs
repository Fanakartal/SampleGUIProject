using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreChanger : MonoBehaviour {

    public GameObject slider;
    float score;

    public void changeScore()
    {
        score = slider.GetComponent<Slider>().value;
        Debug.Log(score);
    }

    public void SaveScore()
    {
        _Game.current = new _Game();
        
        _Game.current.score = score;

        _SaveLoad.Save();

        Application.LoadLevel(0);

        //Debug.Log(_Game.current.score);
    }

    public void LoadScore()
    {
        _SaveLoad.Load();
        slider.GetComponent<Slider>().value = _Game.current.score;
    }
}