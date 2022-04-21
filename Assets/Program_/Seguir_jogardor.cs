using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir_jogardor : MonoBehaviour
{
    public float velocidadeInimigo;

    private Transform posicaoJogador;

    void Start()
    {
        posicaoJogador =    GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        if(posicaoJogador.gameObject != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, posicaoJogador.position, velocidadeInimigo * Time.deltaTime);
        }
    }
}
