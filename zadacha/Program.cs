﻿/* написать программу, которая из имеющегося массива строк формирует массив строк, длина котроых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполения алгоритма. при решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами. */

Console.WriteLine(" Введите с клавиатуры элементы массива");
string [] massiv = new string [10]; // объявляю изначальный массив
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = Console.ReadLine(); // заполняю изначальный массив
}
Console.WriteLine("Изначальный массив: ");
for (int i = 0; i < massiv.Length; i++)
{
    Console.Write(massiv[i] + " "); // демностирую заполенный изначальный массив
}
Console.WriteLine();
int  LENGTH = 3; // ввожу ограничитель длины элемента массива
int j = 0; // переменная для перебора элементов формируемого массива
string [] result = new string [massiv.Length]; // объявляю формируемый массив
for (int i = 0; i < massiv.Length; i++)
{
if(massiv[i].Length<=LENGTH)
{
result[j] = massiv[i]; // заполняю формруемый массив элементами изначальнго массива согласно условию задачи
j++;
}
}
Console.WriteLine("Сформированный массив: ");
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " "); // вывожу сформированный массив
}