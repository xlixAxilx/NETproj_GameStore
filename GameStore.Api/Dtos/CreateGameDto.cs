﻿using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record class CreateGameDto(
    // attribute - property
    [Required]
    [StringLength(50)]
    string Name,
    
    [Required]
    [StringLength(20)]
    string Genre,

    [Range(1,100)]
    decimal Price,

    DateOnly ReleaseDate
    );

// use data notations to guard agains invalid input