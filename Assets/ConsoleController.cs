using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Assets;

public class ConsoleController : MonoBehaviour
{
    public Image TextBox;
    public Image SelectionPanel;
    
    private bool textadvanced;
    private bool selectionSelected;
    public GameObject BattleLogic;
    private PlayerStats stats;
    // Start is called before the first frame update
    void Start()
    {
        stats = FindObjectOfType<PlayerStats>();
        textadvanced = true;
        selectionSelected = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (textadvanced)
        {
            TextBox.gameObject.SetActive(false);
        }
        if (selectionSelected)
        {
            SelectionPanel.gameObject.SetActive(false);
        }

    }

    public void DisplayText(string text)
    {
        TextBox.gameObject.SetActive(true);
        foreach(Text t in TextBox.gameObject.GetComponentsInChildren<Text>())
        {
            t.text = text;
        }
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
        List<string> s = new List<string>();
        foreach(Assets.System sy in stats.systems)
        {
            s.Add(sy.DisplayName);
        }
        Variables.Object(SelectionPanel.gameObject).Set("Options", s);
        SelectionPanel.gameObject.SetActive(true);
        selectionSelected = false;
    }
}
