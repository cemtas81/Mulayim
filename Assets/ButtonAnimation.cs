﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void button_touch(){
        GetComponent <Animation>().Play("UiButtons");
    }
    


    // Update is called once per frame
    
}
