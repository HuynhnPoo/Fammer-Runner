using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonClick : MonoBehaviour
{
    [SerializeField] protected Button button;
    // Start is called before the first frame update
   
    protected virtual void Start()
    {
        LoadButton();
        AddClickEvent();
    }
    void LoadButton()
    {
        if (button == null)
        {
            button = GetComponent<Button>();
        }
    }

    public virtual void AddClickEvent()
    {
        this.button.onClick.AddListener(this.OnClick);
    }
    public abstract void OnClick();

}
