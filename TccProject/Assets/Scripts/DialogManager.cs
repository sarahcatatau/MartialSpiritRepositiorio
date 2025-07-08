using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Image charImage;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private DialogBar dialogBar;

    [SerializeField] private float intervalBetweenSentences = 1;
    void Start()
    {
        GameEvents.Instance.OnStartDialog += HandleStartDialog;
    }

    public void HandleStartDialog(DialogoSo dialogData)
    {
        StartCoroutine(StartDialog(dialogData));
        Debug.Log("oi");
    }
    public IEnumerator StartDialog(DialogoSo dialogData)
    {
        charImage.enabled = false;
        nameText.SetText("");
        
        yield return dialogBar.ShowBar();
        charImage.enabled = true;
        foreach (var sentence in dialogData.Sentence)
        {
            nameText.SetText(sentence.ActorData.CharName);
            charImage.sprite = sentence.ActorData.Sprite;
            yield return new WaitForSeconds(intervalBetweenSentences);
        }
        yield return dialogBar.HideBar();
        
    }
    void OnDestroy()
    {
        GameEvents.Instance.OnStartDialog -= HandleStartDialog;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
