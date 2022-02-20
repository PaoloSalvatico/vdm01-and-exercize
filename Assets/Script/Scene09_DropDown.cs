using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene09_DropDown : MonoBehaviour
{
    public GameObject[] list;
    private void Start()
    {
        var dropdown = GetComponent<Dropdown>();

        dropdown.onValueChanged.AddListener(delegate { DropdownSelected(dropdown); });

        DropdownSelected(dropdown);
    }

    public void DropdownSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        foreach(var l in list)
        {
            l.SetActive(false);
            list[index].SetActive(true);
        }
    }
}
