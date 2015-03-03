﻿// This file is part of Hangfire.
// Copyright © 2015 Sergey Odinokov.
// 
// Hangfire is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as 
// published by the Free Software Foundation, either version 3 
// of the License, or any later version.
// 
// Hangfire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public 
// License along with Hangfire. If not, see <http://www.gnu.org/licenses/>.

namespace Hangfire.Dashboard
{
    public class Metric
    {
        public Metric(params long[] values)
        {
            Values = values;
        }

        public long[] Values { get; private set; }
        public MetricStyle Style { get; set; }
        public bool Highlighted { get; set; }
    }

    public enum MetricStyle
    {
        None,
        Info,
        Success,
        Warning,
        Danger
    }

    public static class MetricStyleExtensions
    {
        public static string ToClassName(this MetricStyle style)
        {
            switch (style)
            {
                case MetricStyle.Info:    return "metric-info";
                case MetricStyle.Success: return "metric-success";
                case MetricStyle.Warning: return "metric-warning";
                case MetricStyle.Danger:  return "metric-danger";
                default:                  return "metric-default";
            }
        }
    }
}
