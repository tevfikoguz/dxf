// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System.Linq;
using System.Collections.Generic;
using IxMilia.Dxf.Collections;
using IxMilia.Dxf.Sections;
using IxMilia.Dxf.Tables;

namespace IxMilia.Dxf
{
    public partial class DxfUcs : DxfSymbolTableFlags
    {
        internal const string AcDbText = "AcDbUCSTableRecord";

        protected override DxfTableType TableType { get { return DxfTableType.Ucs; } }

        public DxfPoint Origin { get; set; }
        public DxfVector XAxis { get; set; }
        public DxfVector YAxis { get; set; }
        public DxfOrthographicViewType OrthographicViewType { get; set; }
        public double Elevation { get; set; }
        public uint BaseUcsHandle { get; set; }
        public DxfOrthographicViewType OrthographicType { get; set; }
        public DxfPoint OrthographicOrigin { get; set; }

        public DxfXData XData { get; set; }

        public DxfUcs()
            : base()
        {
            Origin = DxfPoint.Origin;
            XAxis = DxfVector.XAxis;
            YAxis = DxfVector.XAxis;
            OrthographicViewType = DxfOrthographicViewType.None;
            Elevation = 0.0;
            BaseUcsHandle = 0u;
            OrthographicType = DxfOrthographicViewType.Top;
            OrthographicOrigin = DxfPoint.Origin;
        }

        internal override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(100, AcDbText));
            }

            pairs.Add(new DxfCodePair(2, Name));
            pairs.Add(new DxfCodePair(70, (short)StandardFlags));
            pairs.Add(new DxfCodePair(10, (Origin.X)));
            pairs.Add(new DxfCodePair(20, (Origin.Y)));
            pairs.Add(new DxfCodePair(30, (Origin.Z)));
            pairs.Add(new DxfCodePair(11, (XAxis.X)));
            pairs.Add(new DxfCodePair(21, (XAxis.Y)));
            pairs.Add(new DxfCodePair(31, (XAxis.Z)));
            pairs.Add(new DxfCodePair(12, (YAxis.X)));
            pairs.Add(new DxfCodePair(22, (YAxis.Y)));
            pairs.Add(new DxfCodePair(32, (YAxis.Z)));
            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(79, (short)(OrthographicViewType)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(146, (Elevation)));
            }

            if (BaseUcsHandle != 0u && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(346, UIntHandle(BaseUcsHandle)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(71, (short)(OrthographicType)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(13, (OrthographicOrigin.X)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(23, (OrthographicOrigin.Y)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(33, (OrthographicOrigin.Z)));
            }

            if (XData != null)
            {
                XData.AddValuePairs(pairs, version, outputHandles);
            }
        }

        internal static DxfUcs FromBuffer(DxfCodePairBufferReader buffer)
        {
            var item = new DxfUcs();
            while (buffer.ItemsRemain)
            {
                var pair = buffer.Peek();
                if (pair.Code == 0)
                {
                    break;
                }

                buffer.Advance();
                switch (pair.Code)
                {
                    case 70:
                        item.StandardFlags = (int)pair.ShortValue;
                        break;
                    case DxfCodePairGroup.GroupCodeNumber:
                        var groupName = DxfCodePairGroup.GetGroupName(pair.StringValue);
                        item.ExtensionDataGroups.Add(DxfCodePairGroup.FromBuffer(buffer, groupName));
                        break;
                    case 10:
                        item.Origin = item.Origin.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 20:
                        item.Origin = item.Origin.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 30:
                        item.Origin = item.Origin.WithUpdatedZ(pair.DoubleValue);
                        break;
                    case 11:
                        item.XAxis = item.XAxis.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 21:
                        item.XAxis = item.XAxis.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 31:
                        item.XAxis = item.XAxis.WithUpdatedZ(pair.DoubleValue);
                        break;
                    case 12:
                        item.YAxis = item.YAxis.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 22:
                        item.YAxis = item.YAxis.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 32:
                        item.YAxis = item.YAxis.WithUpdatedZ(pair.DoubleValue);
                        break;
                    case 79:
                        item.OrthographicViewType = (DxfOrthographicViewType)(pair.ShortValue);
                        break;
                    case 146:
                        item.Elevation = (pair.DoubleValue);
                        break;
                    case 346:
                        item.BaseUcsHandle = UIntHandle(pair.StringValue);
                        break;
                    case 71:
                        item.OrthographicType = (DxfOrthographicViewType)(pair.ShortValue);
                        break;
                    case 13:
                        item.OrthographicOrigin = item.OrthographicOrigin.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 23:
                        item.OrthographicOrigin = item.OrthographicOrigin.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 33:
                        item.OrthographicOrigin = item.OrthographicOrigin.WithUpdatedZ(pair.DoubleValue);
                        break;
                    case (int)DxfXDataType.ApplicationName:
                        item.XData = DxfXData.FromBuffer(buffer, pair.StringValue);
                        break;
                    default:
                        item.TrySetPair(pair);
                        break;
                }
            }

            return item;
        }
    }
}
