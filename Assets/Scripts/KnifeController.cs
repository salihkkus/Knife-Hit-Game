using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
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
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Circle"))
        {
            CanShoot = false;
            kniferb.isKinematic = true;
            kniferb.constraints = RigidbodyConstraints2D.FreezeAll;
            transform.SetParent(other.gameObject.transform);
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
    }


}
