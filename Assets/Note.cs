using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;

    public AudioSource source2;
    public AudioClip bam1;
    public AudioClip bam2;

    public GameObject StrikeBack;


    // Start is called before the first frame update
    void Start()
    {
        StrikeBack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                //gameObject.SetActive(false);
                Debug.Log("hit");
                source2.PlayOneShot(bam2);
                StartCoroutine(Wait());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
            source2.PlayOneShot(bam1);
        }
    }

        private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = false;
        }
    }

       

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(0.2f);
            StrikeBack.SetActive(true);
        }
}
