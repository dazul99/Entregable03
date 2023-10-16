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
    [SerializeField] private int day2;
    [SerializeField] private int month2;

    [SerializeField] private string weekday;

    [SerializeField] private int age;
    [SerializeField] private string rank;

    [SerializeField] private float angle1;
    [SerializeField] private float angle2;
    [SerializeField] private float angle3;
    void Start()
    {
        //EJERCICIO 1
        if (int1 > int2)
        {
            Debug.Log(int1 + " > " + int2);
        }
        else if (int1 < int2)
        {
            Debug.Log(int2 + " > " + int1);
        }
        else
        {
            Debug.Log(int1 + " = " + int2);
        }

        //EJERCICIO 2

        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
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

        if (int1 % int2 == 0)
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
        else if (grade == "C")
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
        else if (0 > month || month > 12)
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

        if (day < 1)
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
        else if (chin % 12 == 2)
        {
            Debug.Log("Chinese year of the dog");
        }
        else if (chin % 12 == 3)
        {
            Debug.Log("Chinese year of the pig");
        }
        else if (chin % 12 == 4)
        {
            Debug.Log("Chinese year of the rat");
        }
        else if (chin % 12 == 5)
        {
            Debug.Log("Chinese year of the ox");
        }
        else if (chin % 12 == 6)
        {
            Debug.Log("Chinese year of the tiger");
        }
        else if (chin % 12 == 7)
        {
            Debug.Log("Chinese year of the rabbit");
        }
        else if (chin % 12 == 8)
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

        if (month2 == 1)
        {
            if (day2 <= 20)
            {
                Debug.Log("Capricorn");
            }
            else
            {
                Debug.Log("Aquarius");
            }
        }
        if (month2 == 2)
        {
            if (day2 <= 19)
            {
                Debug.Log("Aquarius");
            }
            else
            {
                Debug.Log("Pisces");
            }

        }
        if (month2 == 3)
        {
            if (day2 <= 20)
            {
                Debug.Log("Pisces");
            }
            else
            {
                Debug.Log("Aries");
            }

        }
        if (month2 == 4)
        {
            if (day2 <= 20)
            {
                Debug.Log("Aries");
            }
            else
            {
                Debug.Log("Taurus");
            }

        }
        if (month2 == 5)
        {
            if (day2 <= 21)
            {
                Debug.Log("Taurus");
            }
            else
            {
                Debug.Log("Gemini");
            }

        }
        if (month2 == 6)
        {
            if (day2 <= 21)
            {
                Debug.Log("Gemini");
            }
            else
            {
                Debug.Log("Cancer");
            }

        }
        if (month2 == 7)
        {
            if (day2 <= 23)
            {
                Debug.Log("Cancer");
            }
            else
            {
                Debug.Log("Leo");
            }

        }
        if (month2 == 8)
        {
            if (day2 <= 23)
            {
                Debug.Log("Leo");
            }
            else
            {
                Debug.Log("Virgo");
            }

        }
        if (month2 == 9)
        {
            if (day2 <= 23)
            {
                Debug.Log("Virgo");
            }
            else
            {
                Debug.Log("Libra");
            }

        }
        if (month2 == 10)
        {
            if (day2 <= 23)
            {
                Debug.Log("Libra");
            }
            else
            {
                Debug.Log("Scorpio");
            }

        }
        if (month2 == 11)
        {
            if (day2 <= 22)
            {
                Debug.Log("Scorpio");
            }
            else
            {
                Debug.Log("Sagittarius");
            }

        }
        if (month2 == 12)
        {
            if (day2 <= 21)
            {
                Debug.Log("Sagittarius");
            }
            else
            {
                Debug.Log("Capricorn");
            }

        }

        //EJERCICIO 8
        if(weekday == "sunday" || weekday == "saturday")
        {
            Debug.Log("Fin de semana!");
        }

        //EJERCICIO 9
        if (age >= 65)
        {
            if (rank == "gold")
            {
                Debug.Log("75%");
            }
            else if (rank == "silver")
            {
                Debug.Log("50%");
            }
            else
            {
                Debug.Log("25%");
            }
        }
        else if (age >= 18)
        {
            if (rank == "gold")
            {
                Debug.Log("50%");
            }
            else if (rank == "silver")
            {
                Debug.Log("25%");
            }
            else
            {
                Debug.Log("15%");
            }
        }
        else
        {
            Debug.Log("0%");
        }

        //EJERCICIO 10

        if (angle1 + angle2 + angle3 == 180)
        {
            Debug.Log("Los angulos pueden ser los angulos internos de un triangulo");
        }
        else
        {
            Debug.Log("Los angulos NO pueden ser los angulos internos de un triangulo");
        }
    }
}