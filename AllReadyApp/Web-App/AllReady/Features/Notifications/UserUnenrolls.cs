﻿using System.Collections.Generic;
using MediatR;

namespace AllReady.Features.Notifications
{
    public class UserUnenrolls : IAsyncNotification
    {
        public int ActivityId { get; set; }
        public string UserId { get; set; }
        public List<int> TaskIds { get; set; }
    }
}
