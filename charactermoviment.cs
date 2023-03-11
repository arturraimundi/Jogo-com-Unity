using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermoviment : MonoBehaviour
{
    private float horizontal;   
    private float vertical; 
    [SerializeField] private int velocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, vertical, 0)* Time.deltaTime * velocidade);
    }
}
