using First.Domain.Entities;

namespace First.Application.Dtos;

public class ViewTaskDto
{
    public int Id{get;set;}
    public string Title{get;set;}=string.Empty;
    public string Description{get;set;}=string.Empty;

    public string Status{get;set;}=string.Empty;
    public int AssignedTo{get;set;}
}