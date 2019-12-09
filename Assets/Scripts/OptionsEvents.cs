using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OptionsEvents : MonoBehaviour, IPointerClickHandler
{
    public GameObject green_option;
    public GameObject yellow_option;
    public GameObject red_option;
    public GameObject gray_option;

    private bool isOptionExpanded;

    // Start is called before the first frame update
    void Start()
    {
        // transform to method
        green_option = GameObject.Find("HotSpots/photo01_sphere/Options/Green_option");
        yellow_option = GameObject.Find("HotSpots/photo01_sphere/Options/Yellow_option");
        red_option = GameObject.Find("HotSpots/photo01_sphere/Options/Red_option");
        gray_option = GameObject.Find("HotSpots/photo01_sphere/Options/Gray_option");
        isOptionExpanded = false;
        green_option.SetActive(false);
        yellow_option.SetActive(false);
        red_option.SetActive(false);
        gray_option.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(isOptionExpanded == false)
        {
            green_option.SetActive(true);
            yellow_option.SetActive(true);
            red_option.SetActive(true);
            gray_option.SetActive(true);
            isOptionExpanded = true;

        } else
        {
            green_option.SetActive(false);
            yellow_option.SetActive(false);
            red_option.SetActive(false);
            gray_option.SetActive(false);
            isOptionExpanded = false;
        }
    
        
    }
}
