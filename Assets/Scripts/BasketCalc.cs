using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using TMPro;
using UnityEngine;

public class BasketCalc : MonoBehaviour
{

    public TextMeshPro txt_calc;
    private int count;
    private void OnTriggerEnter2D(Collider2D collision) {
      //  Debug.Log(collision.name.IndexOf("Cut_1"));
        if (collision.name.IndexOf("Cut_1") == 0) {
            Debug.Log("+1");
            count++;
            txt_calc.text = count.ToString();
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //        Debug.Log(collision.name);
        count--;
        txt_calc.text = count.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
