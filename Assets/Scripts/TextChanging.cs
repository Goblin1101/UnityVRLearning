using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BNG;

public class TextChanging : MonoBehaviour
{

    Text textToDisplay;
    public BNG.Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        textToDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textToDisplay.text = slider.SlidePercentage.ToString();
    }
}
