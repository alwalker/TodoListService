﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoListService.Web.Models
{
    public class TodoCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}