using Application.DTOs;
using Domain.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories;

public interface IMachineRepository : IGenericRepository<Machine>
{
    Task<PaginationResponseDto<MachineDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
}
