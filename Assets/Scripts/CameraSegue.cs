using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    public GameObject player;
    public float pX;
    public float pY;
    public float limiteX = -3;
    public float limiteY = -1;
    public Vector3 posInicial;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            pX = player.transform.position.x;
            pY = player.transform.position.y;
        }
        
        if(pX > limiteX && pY > limiteY)
        {
            transform.position = new Vector3(pX, pY, -1);
        }

        if(player == null)
        {
            player = GameObject.FindWithTag("Player");
            transform.position = posInicial;
        }
        
    }
}
