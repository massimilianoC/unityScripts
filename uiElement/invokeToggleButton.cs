using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class invokeToggleButton : MonoBehaviour
{
    public Toggle toggleToInvoke;
    public Button buttonToInvoke;

    public List<Button> buttons = new List<Button>();
    public List<Toggle> toggles = new List<Toggle>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void triggerToggleDefault()
    {
        invokeToggle(toggleToInvoke);
    }

    public void triggerButtonDefault()
    {
        invokeButton(buttonToInvoke);
    }

    public void invokeToggle(Toggle invk)
    {
        invk.Select();
        invk.isOn = true;
    }

    public void invokeButton(Button btn)
    {
        btn.onClick.Invoke();
    }

    public void invokeAllToggles()
    {
        foreach(Toggle tg in toggles)
        {
            invokeToggle(tg);
        }
    }

    public void invokeAllButtons()
    {
        foreach (Button bt in buttons)
        {
            invokeButton(bt);
        }
    }

    public void clickButtonByName(string name)
    {
        if (GameObject.Find(name))
        {
            if (GameObject.Find(name).gameObject.GetComponent<Button>())
            {
                Button btn = GameObject.Find(name).gameObject.GetComponent<Button>();
                invokeButton(btn);
            }
        }
        
    }

    public void clickToggleByName()
    {
        if (GameObject.Find(name))
        {
            if (GameObject.Find(name).gameObject.GetComponent<Toggle>())
            {
                Toggle tgl = GameObject.Find(name).gameObject.GetComponent<Toggle>();
                invokeToggle(tgl);
            }
        }
    }
}
