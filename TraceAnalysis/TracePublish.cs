﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceAnalysis
{
    public class TracePublish : TraceEntry
    {
        public string EventName { get; set; }

        public TracePublish(DateTime occurredAt, string content)
            : base(occurredAt, content)
        {
            string[] parts = content.Split(' ');
            this.EventName = parts[1];
        }

    }
}
