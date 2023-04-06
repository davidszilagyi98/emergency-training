using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class helpothers : MonoBehaviour {

    [Space(10)]
    [Header("Toggle for the gui on off")]
    public bool GuiOn;


    [Space(10)]
    [Header("The text to Display on Trigger")]
    [Tooltip("To edit the look of the text Go to Assets > Create > GUIskin. Add the new Guiskin to the Custom Skin proptery. If you select the GUIskin in your project tab you can now adjust the Label section to change this text")]
    public string Text = "Turn Back";

    [Tooltip("This is the window Box's size. It will be mid screen. Add or reduce the X and Y to move the box in Pixels. ")]
    public Rect BoxSize = new Rect( 0, 0, 200, 100);


    [Space(10)]
    [Tooltip("To edit the look of the text Go to Assets > Create > GUIskin. Add the new Guiskin to the Custom Skin proptery. If you select the GUIskin in your project tab you can now adjust the font, colour, size etc of the text")]
    public GUISkin customSkin;

    private bool hasTriggered = false; // new variable to keep track of whether the player has triggered the GUI

    void Awake () {
        GuiOn = false;
    }
    
    // if the player enters the trigger zone and hasn't triggered the GUI yet, display the Gui
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player") && !hasTriggered) 
        {
            GuiOn = true;
        }
    }


    // if the player exits the trigger zone, hide the Gui
    void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            GuiOn = false;
        }
    }

    void OnGUI()
    {
        if (customSkin != null)
        {
            GUI.skin = customSkin;
        }

        if (GuiOn == true)
        {
            // Make a group on the center of the screen
            GUI.BeginGroup (new Rect ((Screen.width - BoxSize.width) / 2, (Screen.height - BoxSize.height) / 2, BoxSize.width, BoxSize.height));
            // All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.

            GUI.Label(BoxSize, Text);

            // End the group we started above. This is very important to remember!
            GUI.EndGroup ();

            // set hasTriggered to true so the GUI can't be triggered again
            hasTriggered = true;
        }
    }

}
