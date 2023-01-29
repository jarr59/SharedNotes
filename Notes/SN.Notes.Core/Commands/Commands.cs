using MediatR;
using SharedNotes;

namespace SN.Notes.Core.Commands;

/// <summary>
/// Add new note
/// </summary>
/// <param name="UserId"></param>
/// <param name="Written"></param>
public record AddNote(string UserId, string Written) : IRequest;

/// <summary>
/// Remove a note
/// </summary>
/// <param name="UserId"></param>
/// <param name="Id"></param>
public record DeleteNote(string UserId, string Id) : IRequest;

/// <summary>
/// Edit a note
/// </summary>
/// <param name="UserId"></param>
/// <param name="Id"></param>
public record EditNote(string UserId, string Id) : IRequest;

/// <summary>
/// Add users 
/// </summary>
/// <param name="UserId"></param>
/// <param name="Id"></param>
/// <param name="userShared"></param>
public record AddUsers(string UserId, string Id, List<UserSharedVo> Shareds) : IRequest;

/// <summary>
/// 
/// </summary>
/// <param name="UserId"></param>
/// <param name="Id"></param>
/// <param name="shareds"></param>
public record RemoveUsers(string UserId, string Id, List<UserSharedVo> Shareds) : IRequest;