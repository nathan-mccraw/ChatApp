﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MessageEntity
    {
        public virtual int MessageId { get; set; }
        public virtual string Text { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual DateTime DateCreated { get; set; } = DateTime.Now;
    }
}