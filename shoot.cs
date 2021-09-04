using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    [SerializeField] Transform firePosition;

    public bool canAutoFire;


    private bool shooting, canShoot = true;


    public float timeBetweenShots;


    private void Update()
    {
               
            shoot();
        
              
        
    }





    private void shoot()
    {
        if (canAutoFire)
        {

            shooting = Input.GetMouseButton(0);


        }
        else
        {
            shooting = Input.GetMouseButtonDown(0);

        }

        if (shooting && canShoot)
        {
            canShoot = false;

            Instantiate(bullet, firePosition.position, firePosition.rotation);

            StartCoroutine(ResetShot());
        }



    }




    IEnumerator ResetShot()
    {

        yield return new WaitForSeconds(timeBetweenShots);

        canShoot = true;
    
    
    }




}
