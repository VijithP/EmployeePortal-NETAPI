using Employee_Portal.Application.DTOs;

namespace Employee_Portal.Application.Interfaces;

public interface IEmployeeService
{
    Task<EmployeeResponse?> GetByIdAsync(
        int id,
        CancellationToken cancellationToken);

    Task<IReadOnlyList<EmployeeResponse>> GetAllAsync(
        CancellationToken cancellationToken);

    Task<EmployeeResponse> CreateAsync(
        CreateEmployeeRequest request,
        CancellationToken cancellationToken);

    Task<EmployeeResponse?> UpdateAsync(
        int id,
        UpdateEmployeeRequest request,
        CancellationToken cancellationToken);

    Task<bool> DeleteAsync(
        int id,
        CancellationToken cancellationToken);
}