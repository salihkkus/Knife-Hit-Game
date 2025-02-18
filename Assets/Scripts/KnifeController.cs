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
