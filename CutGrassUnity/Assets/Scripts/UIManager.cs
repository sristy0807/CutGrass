using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public GameObject[] UIPanels;
    private GameObject activeUIPanel;

    [Header("Settings UI")] 
    public Slider VolumeSlider;



    private void Start()
    {
        UIPanels[0].gameObject.SetActive(true);
        activeUIPanel = UIPanels[0];
    }



    #region Common
    public void GoToPanel(GameObject newPanel)
    {
        
        if(activeUIPanel != null)
        {
            GameObject currentPanel = activeUIPanel;
            currentPanel.gameObject.SetActive(false);
        }

        newPanel.gameObject.SetActive(true);
        activeUIPanel = newPanel;
    }
    #endregion



    #region SettingsUI
    public void OnChangeVolumeValue()
    {
        Debug.Log("Volume changing, current value is " + VolumeSlider.value);
    }
    #endregion
}
