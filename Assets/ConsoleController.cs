using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleController : MonoBehaviour
{
    public Image TextBox;
    public Text text_obj;
    public Image SelectionPanel;
    private bool textadvanced;
    private bool selectionSelected;
    // Start is called before the first frame update
    void Start()
    {
        textadvanced = true;
        selectionSelected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(textadvanced)
        {
            TextBox.gameObject.SetActive(false);
        }
        if(selectionSelected)
        {
            SelectionPanel.gameObject.SetActive(false);
        }

    }

    public void DisplayText(string text)
    {
        TextBox.gameObject.SetActive(true);
        text_obj.text = text;
        textadvanced = false;
    }

    public void AdvanceText()
    {
        textadvanced = true;
    }

    public void SelectSelection()
    {
        selectionSelected = true;
    }

    public void DisplayChoices()
    {
        SelectionPanel.gameObject.SetActive(true);
        selectionSelected = false;
    }
}
