﻿using System.ComponentModel.DataAnnotations.Schema;

namespace NomadDashboardAPI.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string ClientId { get; set; }

        public string Status { get; set; }

        public string Rate { get; set; }

        public int Progress { get; set; }

        public string Description { get; set; }

        public string StartDate { get; set; }

        public string DeadLine { get; set; }
    }
}