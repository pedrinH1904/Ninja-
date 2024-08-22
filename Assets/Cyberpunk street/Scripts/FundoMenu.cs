using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundoMedu : MonoBehaviour
{
    public float velocidade;
    public float posXInicial;
    public float posXFinal;
    public Vector3 posInicial;


    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1 * velocidade * Time.deltaTime ,0, 0);

        if(transform.position.x <= posXFinal)
        {
          transform.position = new Vector3(posXInicial, posInicial.y, 0);
        }
    }
}
