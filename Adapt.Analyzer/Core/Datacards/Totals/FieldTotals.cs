﻿namespace Adapt.Analyzer.Core.Datacards.Totals
{
    public class FieldTotals
    {
        public OperationTotals[] OperationTotals { get; }
        public string Description { get; }

        public FieldTotals(string description, OperationTotals[] operationTotals)
        {
            Description = description;
            OperationTotals = operationTotals;
        }
    }
}
