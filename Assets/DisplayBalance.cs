using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayBalance : MonoBehaviour
{

    private TextMeshProUGUI _txtBalance;
    // Start is called before the first frame update
    void Start()
    {
        _txtBalance = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void OnEnable()
    {
        Web3.OnBalanceChange += OnBalanceChange;
    }

    private void OnDisable(){
        Web3.OnBalanceChange -= OnBalanceChange;
    }

    private void OnBalanceChange(double amount){
        _txtBalance.text = amount.ToString();
    }
    
}
