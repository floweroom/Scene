using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text PlayerName;
   
    // Start is called before the first frame update
    void Start()
    {
        PlayerName.text = PlayerPrefs.GetString("PlayerName");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
