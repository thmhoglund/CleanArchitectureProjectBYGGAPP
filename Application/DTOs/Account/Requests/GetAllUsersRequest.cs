using Application.Parameters;

namespace Application.DTOs.Account.Requests;

public class GetAllUsersRequest : PaginationRequestParameter
{
    public string Name { get; set; }
}
