using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    //Definir os limites para criar as comidas
    public Transform borderTop;
    public Transform borderLeft;
    public Transform borderRight;
    public Transform borderBottom;
    //Prefab da comida
    public GameObject foodPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        //defini local que a comida sera criada
        int x = (int)Random.Range(borderLeft.position.x,borderRight.position.x);
        int y = (int)Random.Range(borderTop.position.y, borderBottom.position.y);
        //cria a comida 
        Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
    }

    public void StartSpawnFood()
    {
        InvokeRepeating("Spawn", 3, 4);
    }
}
