﻿using Olx.Service.DTOs.Users;

namespace Olx.Service.Interfaces;

public interface IUserService
{
    /// <summary>
    /// Create new user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<UserViewDto> CreateAsync(UserCreateDto user);

    /// <summary>
    /// Update exist user
    /// </summary>
    /// <param name="id"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<UserViewDto> UpdateAsync(long id, UserUpdateDto user);

    /// <summary>
    /// Delete exist user via ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(long id);

    /// <summary>
    /// Get exist user via ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<UserViewDto> GetByIdAsync(long id);

    /// <summary>
    /// Get list of exist users
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<UserViewDto>> GetAllAsync();
}