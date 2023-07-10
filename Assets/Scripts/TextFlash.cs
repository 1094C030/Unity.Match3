using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFlash : MonoBehaviour
{
    private float AlphaValue = 1.0f;
    private float time = 0f;
    public bool stateup = false;
    public bool statedo = true;
    public Text text;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 0.3f)
        {

            time = 0;
        }
        if (AlphaValue <= 0f)
        {
            statedo = false;
            stateup = true;

        }
        else if (AlphaValue >= 1f)
        {
            statedo = true;
            stateup = false;

        }
        if (statedo == true)
        {
            AlphaValue -= 0.01f;

        }

        if (stateup == true)
        {
            AlphaValue += 0.01f;

        }


        text.color = new Color(1f, 1f, 1f, AlphaValue);

        Debug.Log(AlphaValue);
    }


}
