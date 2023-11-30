using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camDisplayText : MonoBehaviour
{

    private Text displayText;
    // Start is called before the first frame update
    void Start()
    {
        displayText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime time = System.DateTime.Now;

        displayText.text = time.ToString() + " M3/3";
    }
}
