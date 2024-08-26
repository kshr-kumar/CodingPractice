using System.Linq;
using System.Collections.Generic;
using System;

//Task: Given a list of integers, use LINQ to:
//Find all even numbers.
//Find numbers greater than 50.
//Order the numbers in descending order.

List<int> numbers = new List<int>{ 10, 35, 50, 85, 70, 20, 55, 40 };

//Find all even numbers
var EvenNum = numbers.Where(x => x % 2 == 0);


//Find numbers greater than 50
var Greater = numbers.Where(x => x > 50);


//Order the numbers in desc
var Order = numbers.OrderByDescending(x => x);

Console.WriteLine(string.Join(",", EvenNum)); 
Console.WriteLine(string.Join(",",Greater));
Console.WriteLine(string.Join(",",Order));

