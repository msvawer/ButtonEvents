using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject sphere;

    private Animator _buttonAnimator;

    // Start is called before the first frame update
    void Start()
    {
        _buttonAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _buttonAnimator.SetTrigger("ButtonDown");
            SphereCreation();
            Debug.Log("Sphere created");
        }

        
    }

    public void SphereCreation()
    {
        Instantiate(sphere);
    }

}
