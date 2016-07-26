﻿using System;

namespace Cik.Services.Magazine.MagazineService.Command
{
    public class EditCategoryCommand : Shared.Domain.Command
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}