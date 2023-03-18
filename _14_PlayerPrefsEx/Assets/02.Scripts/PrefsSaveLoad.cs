using System;
using System.Collections;
using System.Collections.Generic;
using TMPro; //
using UnityEngine;
using UnityEngine.UI; // 추가

public class PrefsSaveLoad : MonoBehaviour
{
    //public TMP_InputField inputIntKey;

    public TMP_InputField inputIntKey; //직접 연결
    public TMP_InputField inputIntValue;

    public TMP_InputField inputFloatKey;
    public TMP_InputField inputFloatValue;

    public TMP_InputField inputStringKey;
    public TMP_InputField inputStringValue;

    public TMP_InputField outputKey;
    public TMP_InputField outputField;

    public void saveInt()
    {
        PlayerPrefs.SetInt(inputIntKey.text, Int32.Parse(inputIntValue.text));
    }
    public void saveFloat()
    {
        PlayerPrefs.SetFloat(inputFloatKey.text, float.Parse(inputFloatValue.text));
    }
    public void saveString()
    {
        PlayerPrefs.SetString(inputStringKey.text, inputStringValue.text);
    }

    public void loadData()
    {
        int num = PlayerPrefs.GetInt(outputKey.text);
        float fnum = PlayerPrefs.GetFloat(outputKey.text);
        String str = PlayerPrefs.GetString(outputKey.text);

        if (num != 0)
        outputField.text += String.Format($"{outputKey.text} : {num}\r\n");
        if (fnum != 0f)
            outputField.text += String.Format($"{outputKey.text} : {fnum}\r\n");
        if (str != "")
            outputField.text += String.Format($"{outputKey.text} : {str}\r\n");
    }
}
