using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entrega03 : MonoBehaviour
{
    [SerializeField] private int int1;
    [SerializeField] private int int2;

    [SerializeField] private string letter;

    [SerializeField] private string grade;

    [SerializeField] private int day;
    [SerializeField] private int month;
    [SerializeField] private int year;
    private int feb = 28;
    private bool valid = true;

    [SerializeField] private int chin;
    void Start()
    {
        //EJERCICIO 1
        if(int1 > int2)
        {
            Debug.Log(int1 + " > " + int2);
        }
        else if(int1 < int2)
        {
            Debug.Log(int2 + " > " + int1);
        }
        else
        {
            Debug.Log(int1 + " = " + int2);
        }

        //EJERCICIO 2

        if(letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log(letter + " es una vocal");
        }
        if (letter == "A" || letter == "E" || letter == "I" || letter == "O" || letter == "U")
        {
            Debug.Log(letter + " es una vocal");
        }
        else
        {
            Debug.Log(letter + " es una consonante");
        }

        //EJERCICIO 3

        if(int1%int2 == 0)
        {
            Debug.Log("El primer número es divisible por el segundo");
        }
        else
        {
            Debug.Log("El primer número NO es divisible por el segundo");
        }

        //EJERCICIO 4

        if (grade == "D")
        {
            Debug.Log("fail");
        }
        else if(grade == "C") 
        {
            Debug.Log("passed");
        }
        else if (grade == "B")
        {
            Debug.Log("notable");
        }
        else
        {
            Debug.Log("excellent");
        }

        //EJERCICIO 5

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    feb++;
                }
            }
            else
            {
                feb++;
            }
        }

        if (month == 2)
        {
            if (day > feb)
            {
                valid = false;
            }
        }
        else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if (day > 31)
            {
                valid = false;
            }
        }
        else if (0> month || month > 12)
        {
            valid = false;
        }
        else
        {
            if (day > 30)
            {
                valid = false;
            }
        }

        if(day < 1)
        {
            valid = false;
        }

        if (!valid)
        {
            Debug.Log("Fecha no válida");
        }
        else
        {
            Debug.Log("Fecha válida");
        }

        //EJERCICIO 6

        if (chin % 12 == 0)
        {
            Debug.Log("Chinese year of the monkey");
        }
        else if (chin % 12 == 1)
        {
            Debug.Log("Chinese year of the rooster");

        }
        else if(chin % 12 == 2)
        {
            Debug.Log("Chinese year of the dog");
        }
        else if(chin % 12 == 3)
        {
            Debug.Log("Chinese year of the pig");
        }
        else if(chin % 12 == 4)
        {
            Debug.Log("Chinese year of the rat");
        }
        else if(chin % 12 == 5)
        {
            Debug.Log("Chinese year of the ox");
        }
        else if(chin % 12 == 6)
        {
            Debug.Log("Chinese year of the tiger");
        }
        else if(chin % 12 == 7)
        {
            Debug.Log("Chinese year of the rabbit");
        }
        else if (chin % 12 ==8)
        {
            Debug.Log("Chinese year of the dragon");
        }
        else if (chin % 12 == 9)
        {
            Debug.Log("Chinese year of the snake");
        }
        else if (chin % 12 == 10)
        {
            Debug.Log("Chinese year of the horse");
        }
        else if (chin % 12 == 11)
        {
            Debug.Log("Chinese year of the goat");
        }

        //EJERCICIO 7

        if()
    }

}
