using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Bolt;

public class CountTimer : MonoBehaviour
{
    float currentTime=0;
    public float startingTime=150;
    public Text ct;
   
    public GameObject fail;
    private bool canCount;
    public FlowMachine Sman;
    public GameObject scene;
    public Target target;
 
    void Start()
    {
      currentTime=startingTime;
      canCount = true;
   
      
    }
    
    void OnEnable()
    {
        currentTime=startingTime;
        canCount = true;
        Debug.Log("counting");
    }
    
    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        ct.text = currentTime.ToString("0");
        if (currentTime <= 0&&canCount==true)
        {
            currentTime = 0;

            Failed();
            
        }
        DisplayTime(currentTime);
    }
    public void Failed()
    {
        canCount = false;
       
        StartCoroutine(Fail());
    }
    IEnumerator Fail()
    {
        yield return new WaitForSeconds(2);
        fail.SetActive(true);
        yield return new WaitForSeconds(2);
        fail.SetActive(false);
       
        yield return new WaitForSeconds(6);
        Sman.enabled = true;
        target.enabled = true;
        scene.SetActive(false);
        

    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay<0)
        {
            timeToDisplay=0;
        }
        float minutes=Mathf.FloorToInt(timeToDisplay/60);
        float seconds=Mathf.FloorToInt(timeToDisplay%60);
        ct.text=string.Format("{0:00}:{1:00}",minutes,seconds);

    }
}
