﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Blog : IEntity
    {
        public int Id { get; set; }
        public string PhotoURL { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; } 


    }
}
