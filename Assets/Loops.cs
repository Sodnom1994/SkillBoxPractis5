using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Loops : MonoBehaviour
{
    [SerializeField] public int searchNumber = 0;

    void Start()
    {
        BubleSort();
    }

    public void BubleSort()
    {
        int[] array = { 6, 1, 8, 3, 4, 10, 0, 7, 2, 9, 5 };

        Debug.Log($"{array[0]},{array[1]},{array[2]},{array[3]},{array[4]},{array[5]},{array[6]},{array[7]},{array[8]},{array[9]},{array[10]}");

        for (int i = 0; i < array.Length; i++)
        {
            int min = i;
            Debug.Log("");
            for (int j = i+1; j < array.Length - i; j++)
            {
                

                if (array[j] < array[min])
                {
                    min = j;
                   
                }
            }
            //??????
            //int buffer = array[i];
            //array[i] =min;
            //array[j] = buffer;
            //Debug.Log($"{array[0]},{array[1]},{array[2]},{array[3]},{array[4]},{array[5]},{array[6]},{array[7]},{array[8]},{array[9]},{array[10]}");

        }
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Debug.Log($"Массив после сортировки: {array[i]}");
        //}
    }
    //Первое задание
    public void SumsOfEvenNumbers()
    {
        int sum = 0;
        for (int i = 7; i < 22; i++)
        {
            //Debug.Log(i);
            if (i % 2 == 0)
            {
                sum += i;

            }
        }
        Debug.Log(sum);

    }
    //Второе задание
    public void SumsGivenArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }
        Debug.Log(sum);
    }
    //Третье задание
    public void FirstOccurrenceIndex()
    {
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int searchIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchNumber)
            {
                searchIndex = i;
                break;
            }
            else
            {
                searchIndex = -1;
            }
        }
        Debug.Log(searchIndex);

    }
    //Четвертое задание

}
