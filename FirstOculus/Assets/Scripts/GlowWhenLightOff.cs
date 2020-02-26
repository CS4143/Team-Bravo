using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowWhenLightOff : MonoBehaviour
{
    // Start is called before the first frame update
    public Material NewMaterial;
    private Material OldMaterial;
    public GameObject RoomLight;
    void Start()
    {
        OldMaterial = this.gameObject.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (RoomLight.activeInHierarchy == false)
        {
            this.gameObject.GetComponent<Renderer>().material = NewMaterial; 
        }
        else if (RoomLight.activeInHierarchy == true)
        {
            this.gameObject.GetComponent<Renderer>().material = OldMaterial;
        }
    }
}
