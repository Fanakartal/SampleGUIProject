using UnityEngine;
using System.Collections;

public class PanelTurner : MonoBehaviour {

    public void Turner()
    {
        if (gameObject.transform.rotation.y == 0.0f)
        {
            gameObject.transform.Rotate(0, -90.0f, 0);
            Time.timeScale = 1.0f;
        }
        else
        {
            gameObject.transform.Rotate(0, 90.0f, 0);
            Time.timeScale = 0.0f;
        }
    }
}
