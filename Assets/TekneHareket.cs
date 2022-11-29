using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TekneHareket : MonoBehaviour




{   public float hiz ;
    public  Joystick joystick;
    
    public GameObject direks;
    public float dönüş;
    Rigidbody rb ;

  
    


    // Start is called before the first frame update
    void Start()
    { 
      rb=gameObject.GetComponentInParent <Rigidbody>();
      //direks=gameObject.GetComponentInParent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    

    {if (direks.activeSelf==true)  
      
     //direks.transform.Translate(joystick.Vertical*Time.deltaTime*hiz*-1,0,0);
     //direks.transform.Rotate(Vector3.up*joystick.Horizontal*Time.deltaTime*hiz);
      rb.AddRelativeForce(Vector3.right*joystick.Vertical*Time.fixedDeltaTime*hiz*-1);
      Quaternion deltaRotation= Quaternion.Euler(Vector3.up*Time.fixedDeltaTime*joystick.Horizontal*dönüş);
      rb.MoveRotation(rb.rotation*deltaRotation);
    }
}
