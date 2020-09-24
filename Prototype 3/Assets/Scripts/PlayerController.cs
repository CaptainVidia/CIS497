using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode forceMode;
    public float gravityModifer;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    void Start()
    {
        //set reference variable to componenets
        rb = GetComponent<Rigidbody>();

        //set reference to animator component
        playerAnimator = GetComponent<Animator>();
        // set reference to audio component
        playerAudio = GetComponent<AudioSource>();
        //start running animation
        playerAnimator.SetFloat("Speed_f", 1.0f);
        forceMode = ForceMode.Impulse;
        //modify gravity
        if (Physics.gravity.y >-10)
        {
            Physics.gravity *= gravityModifer;
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, forceMode);
            isOnGround = false;

            //set the trigger to play jump animation
            playerAnimator.SetTrigger("Jump_trig");

            //stop playing dirt particle on jump
            dirtParticle.Stop();

            //play jump sound effect
            playerAudio.PlayOneShot(jumpSound, 1.0f);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            //play dirt particle when player hits the ground
            dirtParticle.Play();

        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;

            //play death animation
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);

            //play explosion particle
            explosionParticle.Play();

            //play crash sound effect
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
