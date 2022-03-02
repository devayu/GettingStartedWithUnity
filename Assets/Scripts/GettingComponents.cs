using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingComponents : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D _myBody;
    private BoxCollider2D _myBox;

    private AudioSource _myAudio;
    private Animator _myAnim;
    void Start()
    {
        // getting reference to components attached on my gameObject
        _myBody = GetComponent<Rigidbody2D>();
        _myBox = GetComponent<BoxCollider2D>();
        _myAudio = GetComponent<AudioSource>();
        _myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
