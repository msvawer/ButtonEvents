using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SphereCreation();
            Debug.Log("Sphere created");
        }

        
    }

    public void SphereCreation()
    {
        Instantiate(sphere);
    }

}
