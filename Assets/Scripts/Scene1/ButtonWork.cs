using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWork : MonoBehaviour
{

    public ClicksManager cM;

    public void ButtonClick()
    {
        if (cM != null)
        {
            cM.ResolveClick();
        }
        else
        { 
            Debug.Log("ButtonWork: The ClicksManager is unassigned!"); 
        }
    }
}
