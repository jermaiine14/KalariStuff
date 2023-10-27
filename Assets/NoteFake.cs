using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteFake : MonoBehaviour
{

    public AudioSource source2;
    public AudioClip bam1;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            source2.PlayOneShot(bam1);
        }
    }

        private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            
        }
    }
}
