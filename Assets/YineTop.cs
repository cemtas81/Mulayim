using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YineTop : MonoBehaviour
{
    public Joystick joystick;
    public float hiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*joystick.Vertical*Time.deltaTime*hiz+Vector3.right*joystick.Horizontal*Time.deltaTime*hiz);
    }
}
