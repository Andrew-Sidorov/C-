﻿// Напишите программу, которая выводит случайное трехзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int N = new Random().Next(100,999);

Console.WriteLine("число рандома  " + N);
int a1 = N/10;
int a11 = a1/10;
int a2 = a1%10;
int a3 = N%10;


Console.WriteLine("остаток от числа " + N1);
