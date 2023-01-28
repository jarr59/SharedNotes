namespace SN.Notes.Core.Queries;

/// <summary>
/// 
/// </summary>
/// <param name="UserId"></param>
/// <param name="Contains"></param>
public record GetByUser(string UserId, string Contains);
