using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizeDropDown : MonoBehaviour
{
    public GameObject DropDownList;
    public Text LabelText;
    public string[] itemValues;
    public string GetSelectedValue()
    {
        return selectedValue;
    }

    private bool isDropDownEnabled;
    private string selectedValue;

    private void Start()
    {
        selectedValue = itemValues[0];
        UpdateSelection();
    }

    private void UpdateSelection()
    {
        LabelText.text = selectedValue;
    }

    public void OnDropDownButton()
    {
        if (DropDownList.gameObject.activeInHierarchy)
        {
           //sDropDownEnabled = false;
            DropDownList.gameObject.SetActive(false);
        }
        else
        {
            //isDropDownEnabled = true;
            DropDownList.gameObject.SetActive(true);
        }
    }

    public void OnToggleValueChange(int id)
    {
        selectedValue = itemValues[id];
        UpdateSelection();
        DropDownList.gameObject.SetActive(false);
    }

}
