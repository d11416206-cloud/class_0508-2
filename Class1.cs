using System;
using System.Security.Cryptography.X509Certificates;

public class Person
{
	public string GetName()
	{

	}
}
public string Student()
{
	Public string GetName()
	{

	}
    
}
public string Teacher()
{
    Public string GetName()
    {

    }

}


public interface IName
{
    string GetName();
}

public class Person : IName
{
    public string GetName()
    {
        return "Person";
    }
}

public class Student : IName

{
    public string GetName()
    {
        return "Student";
    }
}

public class Caller
{
    Public void CallName(IName a)
    {
        Console.WriteLine(a);
    }

}

