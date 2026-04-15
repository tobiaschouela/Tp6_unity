using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaludoUIManager : MonoBehaviour
{
    public TextMeshProUGUI txt_saludo;

    // Start is called before the first frame update
    void Start()
    {
        txt_saludo.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
