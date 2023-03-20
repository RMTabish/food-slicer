using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KNIFE2 : MonoBehaviour
{
    public float timeElapsed = 0f;

    private float ClickTimeframe = 0.1f;

    public Animator KnifeAnimator;
    public bool isCutting2;
    private Rect screenBounds;

 void Start()
{
    float screenRightX = Screen.width - 50f; // get the rightmost x-coordinate of the screen (subtract 50 to set the bounds 50 pixels from the right edge)
    float screenBottomY = 250f; // set the bottom y-coordinate of the bounds to 250 pixels from the top of the screen

    float boundsWidth = 50f; // set the width of the bounds to 50 pixels
    float boundsHeight = Screen.height - 250f; // set the height of the bounds to the height of the screen minus the top and bottom margins

    float boundsX = screenRightX - boundsWidth /2f -20; // set the x-coordinate of the bounds to the rightmost x-coordinate minus the width of the bounds
    float boundsY = screenBottomY-200f; // set the y-coordinate of the bounds to the bottom y-coordinate of the screen

    screenBounds = new Rect(boundsX, boundsY, boundsWidth, boundsHeight);
}


    public void SETcut(bool state)
    {
        isCutting2 = state;
        KnifeAnimator.SetBool("isCutting2", state);
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && screenBounds.Contains(Input.mousePosition) && isCutting2 == false)
        {
            timeElapsed = 0f;
            SETcut(true);
        }
        else
        {
            timeElapsed += Time.fixedDeltaTime;

            if (timeElapsed >= ClickTimeframe && isCutting2)
            {
                SETcut(false);
                timeElapsed = 0f;
            }
        }
    }
}
