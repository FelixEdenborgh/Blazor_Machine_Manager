using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor_Machine_Manager.Models
{
    public class Machine
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        public bool IsOnline { get; set; } = false;

        public DateTime LastUpdated { get; set; } = DateTime.Now;

        public string SpecialAbilityOfMachine { get; set; } = string.Empty;
    }
}
