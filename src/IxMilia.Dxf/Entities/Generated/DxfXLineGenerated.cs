// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;
using IxMilia.Dxf.Collections;
using IxMilia.Dxf.Objects;

namespace IxMilia.Dxf.Entities
{
    /// <summary>
    /// DxfXLine class
    /// </summary>
    public partial class DxfXLine : DxfEntity
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.XLine; } }
        protected override DxfAcadVersion MinVersion { get { return DxfAcadVersion.R13; } }
        public DxfPoint FirstPoint { get; set; }
        public DxfVector UnitDirectionVector { get; set; }

        public DxfXLine()
            : base()
        {
        }

        public DxfXLine(DxfPoint firstPoint, DxfVector unitDirectionVector)
            : this()
        {
            this.FirstPoint = firstPoint;
            this.UnitDirectionVector = unitDirectionVector;
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.FirstPoint = DxfPoint.Origin;
            this.UnitDirectionVector = DxfVector.XAxis;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbXline"));
            pairs.Add(new DxfCodePair(10, FirstPoint.X));
            pairs.Add(new DxfCodePair(20, FirstPoint.Y));
            pairs.Add(new DxfCodePair(30, FirstPoint.Z));
            pairs.Add(new DxfCodePair(11, UnitDirectionVector.X));
            pairs.Add(new DxfCodePair(21, UnitDirectionVector.Y));
            pairs.Add(new DxfCodePair(31, UnitDirectionVector.Z));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 10:
                    this.FirstPoint = this.FirstPoint.WithUpdatedX(pair.DoubleValue);
                    break;
                case 20:
                    this.FirstPoint = this.FirstPoint.WithUpdatedY(pair.DoubleValue);
                    break;
                case 30:
                    this.FirstPoint = this.FirstPoint.WithUpdatedZ(pair.DoubleValue);
                    break;
                case 11:
                    this.UnitDirectionVector = this.UnitDirectionVector.WithUpdatedX(pair.DoubleValue);
                    break;
                case 21:
                    this.UnitDirectionVector = this.UnitDirectionVector.WithUpdatedY(pair.DoubleValue);
                    break;
                case 31:
                    this.UnitDirectionVector = this.UnitDirectionVector.WithUpdatedZ(pair.DoubleValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }
}
