using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicksManager : MonoBehaviour
{
    public TextWork tW;
    int clickAmount = 0;
    public void ResolveClick()
    {
        if (tW != null)
        {
            clickAmount++;
            tW.SetText(clickAmount.ToString());
        }
        else
        { 
            Debug.Log("ClicksManager: The TextWork is unassigned!"); 
        }
    }
}
