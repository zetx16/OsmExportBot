﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsmExportBot.Primitives
{
    public struct Point
    {
        public double Lat;
        public double Lon;
        public string Color;

        public Point(double lat, double lon)
        {
            Color = "";
            Lat = lat;
            Lon = lon;
        }
    }
}
