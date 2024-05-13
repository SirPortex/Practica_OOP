using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BushGenerator : MonoBehaviour
{
    public GameObject bush;
    public int width = 3, height = 3;

    private int _num;
    private SpriteRenderer _sprite;
    // Start is called before the first frame update
    void Start()
    {
        _sprite = bush.GetComponent<SpriteRenderer>();
        _num = UnityEngine.Random.Range(-5, 6);
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Instantiate(bush, new Vector2((j + _num) * _sprite.bounds.size.x, (i + _num) * _sprite.bounds.size.y), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
