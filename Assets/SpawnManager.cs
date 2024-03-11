using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Variables
    public GameObject bottle;
    public string[] shuffleBank = { "otra vez", "no mames", "cuidad", "aterrador", "cereza"};

    // Start is called before the first frame update
    void Start()
    {
        //Shuffle words
        Utilities.ArrayUtilities.Shuffle(shuffleBank);
        shuffleBank.CopyTo(bottle.gameObject.GetComponentInChildren<BottleText>().words, 0);

        //Create bottles
        for(int i = 0; i < 5; i++) {
            GameObject newBottle = Instantiate(bottle, new Vector3((i * 3.75f) + -7.73f, -1.23f, 0f), Quaternion.identity);
            newBottle.GetComponent<BottlePrefab>().ID = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //...
    }
}
