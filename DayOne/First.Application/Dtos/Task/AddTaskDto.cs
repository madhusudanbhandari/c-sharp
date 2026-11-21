using First.Domain.Entities;

namespace First.Application.Dtos;

public class AddTaskDto
{
    public string Title{get;set;}=string.Empty;
    public string Description{get;set;}=string.Empty;
    public string Status{get;set;}=string.Empty;
    public int AssignedTo{get;set;}
}