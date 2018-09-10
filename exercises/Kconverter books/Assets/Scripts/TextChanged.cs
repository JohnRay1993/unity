using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using sech;

public class TextChanged : MonoBehaviour
{

    //KKKConverter k = new KKKConverter();

    [SerializeField] private Text myText;
    [SerializeField] private Text label;
    [SerializeField] private InputField inputField;

    public string outStr;

    private void Start()
    {
        InputField input = GetComponent<InputField>();
        if (input != null)
            input.onValueChange.AddListener(SetText);
    }

    public void SetText(string arg0)
    {
        Debug.Log(arg0);
        int i = -1;
        int.TryParse(arg0, out i);
        label.text = i.Convert();//k.Convert(i);
    }

}