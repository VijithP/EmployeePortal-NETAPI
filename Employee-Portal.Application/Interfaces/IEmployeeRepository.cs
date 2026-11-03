using Employee_Portal.Domain.Entities;

namespace Employee_Portal.Application.Interfaces;

public interface IEmployeeRepository
{
    Task<Employee?> GetByIdAsync(
        int id,
        CancellationToken cancellationToken);

    Task<IReadOnlyList<Employee>> GetAllAsync(
        CancellationToken cancellationToken);

    Task<int> AddAsync(
        Employee employee,
        CancellationToken cancellationToken);

    Task<bool> UpdateAsync(
        int id,
        Employee employee,
        CancellationToken cancellationToken);

    Task<bool> DeleteAsync(
        int id,
        CancellationToken cancellationToken);
}