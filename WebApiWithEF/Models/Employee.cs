using System;
using System.Collections.Generic;
using WebApiWithEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApiWithEF.Models;

public partial class Employee
{
    public int EmpNo { get; set; }

    public string Name { get; set; } = null!;

    public decimal Basic { get; set; }

    public int DeptNo { get; set; }
}


public static class EmployeeEndpoints
{
	public static void MapEmployeeEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Employee").WithTags(nameof(Employee));

        group.MapGet("/", async (ExamContext db) =>
        {
            return await db.Employees.ToListAsync();
        })
        .WithName("GetAllEmployees")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Employee>, NotFound>> (int empno, ExamContext db) =>
        {
            return await db.Employees.AsNoTracking()
                .FirstOrDefaultAsync(model => model.EmpNo == empno)
                is Employee model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetEmployeeById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int empno, Employee employee, ExamContext db) =>
        {
            var affected = await db.Employees
                .Where(model => model.EmpNo == empno)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.EmpNo, employee.EmpNo)
                  .SetProperty(m => m.Name, employee.Name)
                  .SetProperty(m => m.Basic, employee.Basic)
                  .SetProperty(m => m.DeptNo, employee.DeptNo)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateEmployee")
        .WithOpenApi();

        group.MapPost("/", async (Employee employee, ExamContext db) =>
        {
            db.Employees.Add(employee);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Employee/{employee.EmpNo}",employee);
        })
        .WithName("CreateEmployee")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int empno, ExamContext db) =>
        {
            var affected = await db.Employees
                .Where(model => model.EmpNo == empno)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteEmployee")
        .WithOpenApi();
    }
}