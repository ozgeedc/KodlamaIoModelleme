﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.Business.Dtos.Requests.Category;

public class UpdateCategoryRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
}
