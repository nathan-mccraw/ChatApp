﻿using API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Hub
{
    public interface IChatClient
    {
        Task ReceiveMessage(MessageModel message);
    }
}