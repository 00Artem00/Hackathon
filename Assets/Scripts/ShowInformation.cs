using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInformation : MonoBehaviour
{
    [SerializeField] private GameObject moreInformtaion;
    [SerializeField] private GameObject button;

    public void ShowCloseInformation()
    {
        moreInformtaion.SetActive(!moreInformtaion.activeSelf); 
    }

    public void ShowButton()
    {
        button.SetActive(true);
    }

    public void CloseButton()
    {
        button.SetActive(false);
    }
}
