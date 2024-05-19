﻿using ExamplePOO.Models;
using ExamplePOO.Interfaces;

ICalculator calculator = new Calculator();
Console.WriteLine(calculator.Split(44, 2));

//------------------------------------

//Computer computer = new Computer();
//computer.ToString();

//------------------------------------

//Person person = new Person("Bella");
//Student student = new Student("Natasha");
//Professor professor = new Professor("Renato");
//professor.Introduce();

//------------------------------------

//Current current = new Current();
//current.Credit(100);
//current.DisplayBalance();

//------------------------------------

//CheckingAccount checkingAccount = new CheckingAccount(123, 10000);
//checkingAccount.ShowBalance();
//checkingAccount.Withdraw(200);
//checkingAccount.ShowBalance();

//------------------------------------

//Student student = new Student();
//student.Name = "Bella";
//student.Age = 19;
//student.Email = "bella.csouza5@gmail.com";
//student.Grade = 10;
//student.Introduce();

//Professor professor = new Professor();
//professor.Name = "Renato";
//professor.Age = 50;
//professor.Salary = 40000;
//professor.Email = "renato.onofre@gmail.com";
//professor.Introduce(); // override (sobreescrito) e overload (nº de parâmetros)