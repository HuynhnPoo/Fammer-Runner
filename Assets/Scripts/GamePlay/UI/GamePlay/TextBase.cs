using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextBase : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI text;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        LoadComponment();
    }

    void LoadComponment()
    {
        if (text == null) text = GetComponent<TextMeshProUGUI>();
    }
}
