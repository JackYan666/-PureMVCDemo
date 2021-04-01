using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject root;
    // Start is called before the first frame update
    void Start()
    {
        MyFacade myFacade = new MyFacade(root);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
