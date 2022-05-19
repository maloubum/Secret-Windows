using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapToggle : MonoBehaviour
{
    public GameObject mapImage;

    public void Toggle() {        
        mapImage.SetActive(!mapImage.activeSelf);
    }


}
