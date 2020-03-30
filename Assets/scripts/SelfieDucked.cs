using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfieDucked : MonoBehaviour
{
    float localetijd = 5;
    private void Update()
    {
        localetijd -= Time.deltaTime;
        if (localetijd < 0)
        {
            Destroy(this.gameObject);
        }

    }
    // Start is called before the first frame update
}
