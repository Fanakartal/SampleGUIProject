using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreChanger : MonoBehaviour {

    public GameObject slider;
    public static float score;

    void Awake()
    {
        if(PlayerPrefs.GetFloat("score") != 0.0f)
            LoadScore();
    }
    
    public void changeScore()
    {
        score = slider.GetComponent<Slider>().value;
        //Debug.Log(score);
    }

    public void SaveScore()
    {

        PlayerPrefs.SetFloat("score", score);
        
        ////_Game.current = new _Game();
        
        //_Game.current.score = score;

        //_SaveLoad.Save();

        Application.LoadLevel(0);

        ////Debug.Log(_Game.current.score);
    }

    public void LoadScore()
    {
        score = PlayerPrefs.GetFloat("score");

        slider.GetComponent<Slider>().value = score;
        //_Game.current = new _Game();
        //_SaveLoad.Load();
        //slider.GetComponent<Slider>().value = _Game.current.score;
    }
}