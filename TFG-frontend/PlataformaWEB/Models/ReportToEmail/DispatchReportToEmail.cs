﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaWEB.Models.ReportToEmail
{
    public class DispatchReportToEmail : ReportToEmail
    {
        public List<DispatchReport> Items { get; set; }
    }
}
