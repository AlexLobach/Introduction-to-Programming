using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{ 
    private enum Operations
    {
        Sum,
        Subtraction,
        Division,
        Multiply
    }

    [Header("Enter two numbers and select a math operation.")]    
    [SerializeField] private float _number1 = 0f;
    [SerializeField] private float _number2 = 0f;
    [SerializeField] private Operations _opertionsType;
    

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Operation result = {Calculat(_number1, _number2)}");
    }

    private float Calculat(float value, float value2)
    {
        if (_opertionsType == Operations.Sum)
        {
            return Sum(value, value2);
        }
        else if (_opertionsType == Operations.Subtraction)
        {
            return Diff(value, value2);
        }
        else if (_opertionsType == Operations.Division)
        {
            return Div(value, value2);
        }
        else
        {
            return Multi(value, value2);
        }
    }

    private float Sum(float value, float value2)
    {
        return value + value2;        
    }
    
    private float Diff(float value, float value2)
    {
        return value - value2;
    }

    private float Div(float value, float value2)
    {
        return value / value2;        
    }

    private float Multi(float value, float value2)
    {
        return value * value2;        
    }   
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
