
public record class Body(
    string? CustomerId,
    string? PartnerId,
    int version)
{

}

public record class CheckPasswordBody(
    string? RooftopId)
{

}

public record class ChassisPrePopulationBody(
    string? CustomerId,
    string? RooftopId,
    string? VIN
    )
{

}

public record class GetServicesBody(
    string? RooftopId,
    string? MakeCode,
    string? ModelCode
    )
{

}