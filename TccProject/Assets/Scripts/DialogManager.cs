using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Image chatImage;
    [SerializeField] private TMP_Text nameText;
    void Start()
    {
        GameEvents.Instance.OnStartDialog += HandleStartDialog;
    }

    private void HandleStartDialog(DialogoSo dialogData)
    {
        throw new NotImplementedException();
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
