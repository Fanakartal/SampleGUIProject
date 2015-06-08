using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIButtonController : MonoBehaviour 
{
    public Animator contentPanel;
    public Animator gearImage;

    void Start()
    {
        RectTransform transform = contentPanel.gameObject.transform as RectTransform;
        Vector2 position = transform.anchoredPosition;
        position.y -= transform.rect.height;
        transform.anchoredPosition = position;
    }
    
    public void GetNextLevel(int nextScene)
    {
        Application.LoadLevel(nextScene);
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void ToggleSettings()
    {
        contentPanel.enabled = true;

        bool isHidden = contentPanel.GetBool("isHidden");
        contentPanel.SetBool("isHidden", !isHidden);

        gearImage.enabled = true;

        bool isHidden2 = gearImage.GetBool("isHidden2");
        gearImage.SetBool("isHidden2", !isHidden2);
    }
}
