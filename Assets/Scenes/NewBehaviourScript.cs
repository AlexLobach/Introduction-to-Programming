using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private int _number1 = 1;
    [SerializeField] private int _number2 = 2;
    [SerializeField] private bool _addition = true;

    // Start is called before the first frame update
    void Start()
    {
        var result = 0;
        if (_addition)
        {
            result = Sum(_number1,_number2);
            Debug.Log($"Результат сложения = {result}");
        }
        else
        {
            result = Diff(_number1,_number2);
            Debug.Log($"Результат вычитания = {result}");
        }
        
    }

    private int Sum(int value, int value2)
    {
        var result = value + value2;
        return result;
    }
    private int Diff(int value, int value2)
    {
        var result = value - value2;
        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
