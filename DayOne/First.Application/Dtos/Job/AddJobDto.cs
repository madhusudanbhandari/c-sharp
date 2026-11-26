namespace First.Domain.Entities;

public class AddJobDto
{
    public string Title{get;set;}=string.Empty;
    public string Description{get;set;}=string.Empty;
    public int Tasks{get;set;}
}