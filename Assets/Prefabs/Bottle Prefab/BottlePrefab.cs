using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class BottlePrefab : MonoBehaviour
{
    //Public Variables
    public SpriteRenderer sprite;
    public Color altColor = new Color(1f, 0.6f, 0.6f, 1f); //Color of sprite when clicked
    public int ID = 0; //Bottle ID number

    //Private Variables
    private static Color mainColor = Color.white;

   // Start is called before the first frame update
    void Start()
    {
        //...
    }

    // Update is called once per frame
    void Update()
    {
        //Get the coordinates of the mouse position in the game
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //If the player uses the left mouse button to click within the bounding box
        if(sprite.bounds.Contains(mousePos) && Input.GetMouseButton(0)) {
            sprite.color = altColor; //Display alt color
        } else {
            sprite.color = mainColor; //Display main color
        }

    }
}
