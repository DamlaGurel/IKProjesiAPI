using IKProjesiAPI.Domain.Entities.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs.UserDTOs
{
    public class ChangePasswordDto
    {
        public string? TemporaryPassword { get; set; }
        public string? NewPassword { get; set; }

    }
}
