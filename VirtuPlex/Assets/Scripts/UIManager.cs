using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform colorPanel;
    public RectTransform optionsPanel;
    public GameObject quitPanel;

    private bool isOptionsPanel;
    private bool isChangeColorPanel;

    public void ToggleOptionsPanel()
    {
        if (!isOptionsPanel)
        {
            optionsPanel.DOAnchorPosX(-205, 0.5f);
            isOptionsPanel = true;
        }
        else
        {
            optionsPanel.DOAnchorPosX(0, 0.5f);
            isOptionsPanel = false;
        }
    }

    public void ToggleChangeColorPanel()
    {
        ToggleOptionsPanel();
        if (!isChangeColorPanel)
        {
            colorPanel.DOAnchorPosY(-455, 0.5f);
            
            isChangeColorPanel = true;
        }
        else
        {
            colorPanel.DOAnchorPosY(-700, 0.5f);
            isChangeColorPanel = false;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ToggleExitButton()
    {
        quitPanel.SetActive(!quitPanel.activeInHierarchy);
    }
}
