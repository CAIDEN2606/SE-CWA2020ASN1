using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    class InspectionArea
    {
        private string m_workareaName;
        public string Work_Area { get { return m_workareaName; } set { m_workareaName = value; } }

        private string m_inspectionSummary;
        public string Inspection_Summary { get { return m_inspectionSummary; } set { m_inspectionSummary = value; } }

    }
}
