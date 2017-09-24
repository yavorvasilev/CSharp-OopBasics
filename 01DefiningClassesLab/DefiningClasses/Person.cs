using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;

    public Person(string name, int age)
        : this(name, age, new List<BankAccount>())
    { }

    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.name = name;
        this.age = age;
        this.accounts = accounts;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == "")
            {
                throw new Exception("Name can't be empty");
            }
            this.name = value;
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Age can't be negative");
            }
            this.age = value;
        }
    }
    public List<BankAccount> Accounts
    {
        get
        {
            return this.accounts;
        }
        set
        {
            this.accounts = value;
        }
    }
    public double GetBalance()
    {
        return this.accounts.Sum(b => b.Balance);
    }
}
