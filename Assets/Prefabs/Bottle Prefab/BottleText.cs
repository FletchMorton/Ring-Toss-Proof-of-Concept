using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class BottleText : MonoBehaviour
{

    //Variables
    public TextMeshPro label;
    public string[] words = new string[5];

    // Start is called before the first frame update
    void Start()
    {
        int index = this.gameObject.GetComponentInParent<BottlePrefab>().ID;
        label.text = words[index];

        //If this bottle's word is the key word, make clicking the bottle indicate such
        if(label.text == "cereza") this.gameObject.GetComponentInParent<BottlePrefab>().altColor = new Color(0.6f, 1f, 0.6f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //...
    }
}
