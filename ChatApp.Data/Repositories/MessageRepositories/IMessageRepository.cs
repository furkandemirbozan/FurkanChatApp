﻿using ChatApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data.Repositories.MessageRepositories
{
    public interface IMessageRepository :IGenericRepository<Message>
    {
    }
}
