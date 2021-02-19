using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWork : MonoBehaviour
{
    public void SetText(string newText)
    {
        this.gameObject.GetComponent<UnityEngine.UI.Text>().text = newText;
    }
}
