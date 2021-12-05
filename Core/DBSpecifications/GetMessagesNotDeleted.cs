﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class GetMessagesNotDeleted : BaseSpecification<MessageEntity>
    {
        public GetMessagesNotDeleted() : base(m => m.DateDeleted == null)
        {
        }
    }
}