﻿int a = 11;
int b = 2;
int c = 6;
int d = 82;
int e = 41;

int max = a;
if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;
if ( d > max ) max = d;
if ( e > max ) max = e;

Console.Write("Максимальное число = ");
Console.WriteLine(max);

