using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 8;
    public float jumpForce = 12;

    private Rigidbody2D myRig;
    bool grouned = true;
    private Animator ani;

    public bool dead;

    public GameManager GameManager;

    void Start()
    {
        myRig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();

        gameObject.GetComponent<Button>();
    }

    void Update()
    {
        if (dead == false)
        {
            myRig.velocity = new Vector2(moveSpeed, myRig.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collsion)
    {
        if (collsion.gameObject.CompareTag("Terrain"))
        {
            grouned = true;
            ani.SetBool("IsRunning", true);
        }
        if (collsion.gameObject.CompareTag("Trap"))
        {
            GameManager.gameOver();
            gameObject.SetActive(false);
            Die();
            dead = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collsion)
    {
        if (collsion.gameObject.name == "Terrain")
        {
            grouned = false;
        }
    }
    private void Die()
    {
        ani.SetTrigger("Death");
        AudioManager.instance.Play("Over");
        Time.timeScale = 0;
    }
    public void jumpButton()
    {
        if (grouned)
        {
            AudioManager.instance.Play("Jump");
            myRig.velocity = Vector3.up * jumpForce;
            ani.SetBool("IsRunning", false);
        }
    }
}
