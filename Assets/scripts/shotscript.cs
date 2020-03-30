using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotscript : MonoBehaviour

{
    public GameObject bullet;
    public float timeLeft;
    public GameObject loca;
    float localetijd;
    public int THEFORCE;
    float timeRight = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        localetijd -= Time.deltaTime;
        if (localetijd < 0)
        {
            spawnbullets();
        }
    }
    void spawnbullets()
    {
        
           GameObject kogwelzas = Instantiate(bullet, loca.transform.position, Quaternion.identity) as GameObject;
            kogwelzas.GetComponent<Rigidbody>().AddForce(transform.up * THEFORCE);
      //  kogwelzas.GetComponent<SelfieDucked>.Koelsbegonna(timeRight);
        localetijd = timeLeft;
      //  deletekogels(kogwelzas);
       

        }

    void deletekogels(GameObject kigelwzas)
    {
        while (timeRight >= 0)
        {
  timeRight -= Time.deltaTime;
        }
          
            if (timeRight < 0)
            {
            Destroy(kigelwzas);
            }


        timeRight = 3.0f;



    }
  
}
