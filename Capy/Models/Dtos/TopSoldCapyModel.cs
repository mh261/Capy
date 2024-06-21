namespace Capy.Models.Dtos;

public record TopSoldCapyModel(string CapyName, string Producer, int TotalUnitSold);
public record TopSoldCapyVm(DateTime StartDate, DateTime EndDate, IEnumerable<TopSoldCapyModel> TopSoldCapy);