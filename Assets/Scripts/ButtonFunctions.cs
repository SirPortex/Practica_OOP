using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        GameManager.instance.LoadScene(sceneName);
    }

    public void SelectCharacter()
    {
        TMP_Dropdown tMP_Dropdown = FindObjectOfType<TMP_Dropdown>();
        GameManager.instance.SelectCharacter(tMP_Dropdown.value);
    }

    public void SetName()
    {
        GameManager.instance.SetName(FindObjectOfType<TMP_InputField>().text);
    }
}
