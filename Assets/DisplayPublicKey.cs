using System.Collections;
using System.Collections.Generic;
using Solana.Unity.SDK;
using Solana.Unity.Wallet;
using UnityEngine;
using TMPro;

public class DisplayPublicKey : MonoBehaviour
{

    private TextMeshProUGUI _txtPublicKey;
    // Start is called before the first frame update
    void Start()
    {
        _txtPublicKey = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void OnEnable()
    {
        Web3.OnLogin += OnLogin;
    }

    private void OnDisable()
    {
        Web3.OnLogin -= OnLogin;
    }

    private void OnLogin(Account account)
    {
        _txtPublicKey.text = account.PublicKey;
    }
    
}
