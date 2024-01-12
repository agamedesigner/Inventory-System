using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class envanterackapa : MonoBehaviour
{
    public GameObject Panel;


    public void OpenPanel()
    {
        if(Panel  != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }

        
}
