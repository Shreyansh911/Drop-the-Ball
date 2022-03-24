using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] Base;
    [SerializeField] float _border = 2.8f;

    [Range(0.2f, 2)]  public float TimeBetweenSpawns = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBlocks());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBlocks()
    {
        
        while (true)
        {
            var floorIndex = Random.Range(0, Base.Length);
            var RandomPosx = Random.Range(_border, -_border);
            yield return new WaitForSeconds(TimeBetweenSpawns);
            Instantiate(Base[floorIndex], new Vector2(RandomPosx, transform.position.y), Quaternion.identity);
        }
    }
}
