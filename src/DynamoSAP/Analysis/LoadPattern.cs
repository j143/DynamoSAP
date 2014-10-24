﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DynamoSAP.Analysis
{
    public class LoadPattern
    {

        //Load Pattern Name
        private string name { get; set; }

        // Type of Load Pattern
        private int type { get; set; }

        // Multiplier
        private double multiplier { get; set; }


        //QUERY NODES
        public string Name { get { return name; } }
        public int Type { get { return type; } }
        public double Multiplier { get { return multiplier; } }

        //DYNAMO NODE
        /// <summary>
        /// This node creates a Load Pattern
        /// </summary>
        /// <param name="Name">The name for the new load pattern</param>
        /// <param name="LoadPatternType">This is one of the following items in the eLoadPatternType enumeration:
        /// LTYPE_DEAD = 1
        /// LTYPE_SUPERDEAD = 2
        /// LTYPE_LIVE = 3
        /// LTYPE_REDUCELIVE = 4
        /// LTYPE_QUAKE = 5
        /// LTYPE_WIND= 6
        /// LTYPE_SNOW = 7
        /// LTYPE_OTHER = 8
        /// LTYPE_MOVE = 9
        /// LTYPE_TEMPERATURE = 10
        /// LTYPE_ROOFLIVE = 11
        /// LTYPE_NOTIONAL = 12
        /// LTYPE_PATTERNLIVE = 13
        /// LTYPE_WAVE= 14
        /// LTYPE_BRAKING = 15
        /// LTYPE_CENTRIFUGAL = 16
        /// LTYPE_FRICTION = 17
        /// LTYPE_ICE = 18
        /// LTYPE_WINDONLIVELOAD = 19
        /// LTYPE_HORIZONTALEARTHPRESSURE = 20
        /// LTYPE_VERTICALEARTHPRESSURE = 21
        /// LTYPE_EARTHSURCHARGE = 22
        /// LTYPE_DOWNDRAG = 23
        /// LTYPE_VEHICLECOLLISION = 24
        /// LTYPE_VESSELCOLLISION = 25
        /// LTYPE_TEMPERATUREGRADIENT = 26
        /// LTYPE_SETTLEMENT = 27
        /// LTYPE_SHRINKAGE = 28
        /// LTYPE_CREEP = 29
        /// LTYPE_WATERLOADPRESSURE = 30
        /// LTYPE_LIVELOADSURCHARGE = 31
        /// LTYPE_LOCKEDINFORCES = 32
        /// LTYPE_PEDESTRIANLL = 33
        /// LTYPE_PRESTRESS = 34
        /// LTYPE_HYPERSTATIC = 35
        /// LTYPE_BOUYANCY = 36
        /// LTYPE_STREAMFLOW = 37
        /// LTYPE_IMPACT = 38
        /// LTYPE_CONSTRUCTION = 39</param>
        /// <param name="Multiplier">The self weight multiplier for the new load pattern.</param>
        /// <returns></returns>
        //public static LoadPattern SetLoadPattern(string Name, eLoadPatternType LoadPatternType, double Multiplier)
        public static LoadPattern SetLoadPattern(string Name, int LType, double Multiplier = 1)
        {
            return new LoadPattern(Name, LType, Multiplier);
        }

        //PRIVATE CONSTRUCTOR
        private LoadPattern(string Name, int LoadPatternType, double Multiplier)
        {
            name = Name;
            type = LoadPatternType;
            multiplier = Multiplier;
        }
    }
}