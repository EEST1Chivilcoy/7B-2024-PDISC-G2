﻿using System.ComponentModel.DataAnnotations;

namespace PaginaEEST1.Data.Enums
{
    public enum TypeShifts
    {
        [Display(Name = "Mañana")]
        Maniana,
        [Display(Name = "Tarde")]
        Tarde,
        [Display(Name = "Nocturno")]
        Nocturno
    }
}
