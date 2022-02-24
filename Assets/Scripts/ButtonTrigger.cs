using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject myaudioGameObj;

    [SerializeField]
    private Animator _buttonAnimator;

    // Start is called before the first frame update
    void Start()
    {
        _buttonAnimator = GetComponent<Animator>();
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
    private void SphereCreation()
    {
        Instantiate(myaudioGameObj);
    }

}
