﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillPortofolio.Api.Models
{
    public class UserActionPoint
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Resources { get; set; }
        public ItemStatus Status { get; set; }
    }
}