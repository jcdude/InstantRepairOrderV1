using InstantRepairOrderV1.Application.Common.Interfaces;
using System;

namespace InstantRepairOrderV1.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
