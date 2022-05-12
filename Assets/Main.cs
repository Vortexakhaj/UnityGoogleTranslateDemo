using UnityEngine;
using UnityEngine.UI;
using UniLang;
using System.Collections.Generic;

public class Main : MonoBehaviour
{
    public InputField textInput;
    public Button translateBtn;
    public Text resultText;
    public Dropdown languageType;

    void Start()
    {
        var languages = new List<string>();
        // ���ļ���
        //languages.Add("zh-cn");
        // ���ķ���
        //languages.Add("zh-tw");
        // Ӣ��
        //languages.Add("en");
        // ����
        languages.Add("kn");
        //languages.Add("ja");
        // ����
        //languages.Add("ko");
        // ����
        //languages.Add("fr");
        // ����
        //languages.Add("de");
        // ����
        //languages.Add("ru");
        languageType.AddOptions(languages);

        translateBtn.onClick.AddListener(() => { Translator.Do("en", "kn", textInput.text, (translated_str) => { resultText.text = translated_str; }); });

        //languageType.onValueChanged.AddListener((v) => { Translate(); });
    }

    public void Translate()
    {
        
    }
}
