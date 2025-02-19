using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnifeController : MonoBehaviour
{
    private KnifeManager knifeManager;
   private Rigidbody2D kniferb;
   [SerializeField] private float movespeed;
   private bool CanShoot;

    void Start()
    {
        GetComponents();
    }

    private void Update()
    {
        HandleShoot();
    }

    private void FixedUpdate()
    {
        Shoot();
    }

    private void HandleShoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
           CanShoot = true;
           knifeManager.SetDisableKnifeIconColor();
        }
            }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Circle"))
        {
            knifeManager.SetActiveKnife();
            CanShoot = false;
            kniferb.isKinematic = true;
            kniferb.constraints = RigidbodyConstraints2D.FreezeAll;
            transform.SetParent(other.gameObject.transform);
        }

        if(other.gameObject.CompareTag("Knife"))
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    private void Shoot()
    {
         if(CanShoot)
         {
           kniferb.AddForce(Vector2.up * movespeed * Time.fixedDeltaTime);
         }
{
}
    }

    private void GetComponents()
    {
        kniferb = GetComponent<Rigidbody2D>();
        knifeManager = GameObject.FindObjectOfType<KnifeManager>();
    }


}
