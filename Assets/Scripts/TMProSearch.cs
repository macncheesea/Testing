using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TMProSearch : MonoBehaviour {

    

    [SerializeField] private InputField inputField;
    [SerializeField] private Dropdown dropdown;

    private List<Dropdown.OptionData> dropdownOptions;

    private void Start() {
        dropdownOptions = dropdown.options;
    }

    public void FilterDropdown(string input) {
        input = input.ToLower();
        dropdown.options = dropdownOptions.FindAll(option => option.text.ToLower().IndexOf(input) >= 0);

        Debug.Log(input);
        Debug.Log(dropdown.value);
    }
}
