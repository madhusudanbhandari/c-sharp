namespace First.Domain.Entities;

public class Job
{
    public int Id{get;set;}
    public string Name{get;set;}=string.Empty;
    public string Description{get;set;}=string.Empty;
    public int Tasks{get;set;}
}