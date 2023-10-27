using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotEnd : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    public AudioSource source2;
    public AudioClip bam3;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                Debug.Log("hit");
                source2.PlayOneShot(bam3);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

        private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = false;
        }
    }
}
