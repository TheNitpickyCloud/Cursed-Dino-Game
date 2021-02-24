using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public float sideForce;
    bool grounded = true;
    bool Shifted = false;
    public Animator anim;
    public GameObject instructions;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            instructions.SetActive(false);
        }

        if(Input.GetButtonDown("Jump") && grounded)
        {
            //Shifted = false;
            anim.SetBool("Jumping", true);
            rb.AddForce(new Vector3(0, force, 0), ForceMode2D.Force);
            //rb.AddForce(new Vector3(sideForce, 0, 0), ForceMode2D.Force);
        }

        else
        {
            anim.SetBool("Jumping", false);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Floor"))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Floor"))
        {
            grounded = false;
        }
    }

    IEnumerator wait(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
