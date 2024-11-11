using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public abstract class SliderBase : MonoBehaviour
{
   [SerializeField] protected Slider slider;
    // Start is called before the first frame update
     protected virtual void Start()
    {
        LoadSlider();
        this.AddChangeEvent();
    }

   
    void LoadSlider()
    {
        if (this.slider != null) return;
        this.slider = GetComponent<Slider>();
    }

    protected void AddChangeEvent()
    {
        this.slider.onValueChanged.AddListener(this.OnChange);
    }

    protected abstract void OnChange(float value);

   
}
