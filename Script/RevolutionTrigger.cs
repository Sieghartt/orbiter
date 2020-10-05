using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RevolutionTrigger : MonoBehaviour
{
    private float rev = -1;

    public Text revText;

    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "RevCounter")
        {
            rev++;
            revText.text = rev.ToString();
        }
    }
}
