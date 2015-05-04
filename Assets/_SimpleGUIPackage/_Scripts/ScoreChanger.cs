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

        Application.LoadLevel(0);
    }

    public void LoadScore()
    {
        score = PlayerPrefs.GetFloat("score");

        slider.GetComponent<Slider>().value = score;
    }
}