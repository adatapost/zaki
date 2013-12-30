using System;
using System.Collections.Generic;

public class Emp
{
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsAdhoc { get; set; }

    public static List<Emp> GetEmps()
    {
        List<Emp> emps = new List<Emp>()
            {
                new Emp(){ ID=10,Name="A", IsAdhoc=true},
                new Emp(){ ID=11,Name="B", IsAdhoc=false},
            };
        emps.Add(new Emp() { ID = 90, IsAdhoc = true, Name = "R" });
        return emps;
    }
}