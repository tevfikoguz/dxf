// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System.Linq;
using System.Collections.Generic;
using IxMilia.Dxf.Collections;
using IxMilia.Dxf.Sections;
using IxMilia.Dxf.Tables;

namespace IxMilia.Dxf
{
    public partial class DxfView : DxfSymbolTableFlags
    {
        internal const string AcDbText = "AcDbViewTableRecord";

        protected override DxfTableType TableType { get { return DxfTableType.View; } }

        public double ViewHeight { get; set; }
        public DxfPoint ViewCenterPoint { get; set; }
        public double ViewWidth { get; set; }
        public DxfVector ViewDirection { get; set; }
        public DxfPoint TargetPoint { get; set; }
        public double LensLength { get; set; }
        public double FrontClippingPlane { get; set; }
        public double BackClippingPlane { get; set; }
        public double TwistAngle { get; set; }
        public short ViewMode { get; set; }
        public DxfViewRenderMode RenderMode { get; set; }
        public bool IsAssociatedUCSPresent { get; set; }
        public bool IsCameraPlottable { get; set; }
        public uint BackgroundObjectPointer { get; set; }
        public uint SelectionObjectPointer { get; set; }
        public uint VisualStyleObjectPointer { get; set; }
        public uint SunOwnershipPointer { get; set; }
        public DxfPoint UCSOrigin { get; set; }
        public DxfVector UCSXAxis { get; set; }
        public DxfVector UCSYAxis { get; set; }
        public DxfOrthographicViewType OrthographicViewType { get; set; }
        public double UCSElevation { get; set; }
        public uint UCSHandle { get; set; }
        public uint BaseUCSHandle { get; set; }

        public DxfXData XData { get; set; }

        public DxfView()
            : base()
        {
            ViewHeight = 1.0;
            ViewCenterPoint = DxfPoint.Origin;
            ViewWidth = 1.0;
            ViewDirection = DxfVector.ZAxis;
            TargetPoint = DxfPoint.Origin;
            LensLength = 1.0;
            FrontClippingPlane = 0.0;
            BackClippingPlane = 1.0;
            TwistAngle = 0.0;
            ViewMode = 0;
            RenderMode = DxfViewRenderMode.Classic2D;
            IsAssociatedUCSPresent = false;
            IsCameraPlottable = false;
            BackgroundObjectPointer = 0u;
            SelectionObjectPointer = 0u;
            VisualStyleObjectPointer = 0u;
            SunOwnershipPointer = 0u;
            UCSOrigin = DxfPoint.Origin;
            UCSXAxis = DxfVector.XAxis;
            UCSYAxis = DxfVector.YAxis;
            OrthographicViewType = DxfOrthographicViewType.None;
            UCSElevation = 0.0;
            UCSHandle = 0u;
            BaseUCSHandle = 0u;
        }

        internal override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(100, AcDbText));
            }

            pairs.Add(new DxfCodePair(2, Name));
            pairs.Add(new DxfCodePair(70, (short)StandardFlags));
            pairs.Add(new DxfCodePair(40, EnsurePositiveOrDefault(1.0)(ViewHeight)));
            pairs.Add(new DxfCodePair(10, (ViewCenterPoint.X)));
            pairs.Add(new DxfCodePair(20, (ViewCenterPoint.Y)));
            pairs.Add(new DxfCodePair(41, EnsurePositiveOrDefault(1.0)(ViewWidth)));
            pairs.Add(new DxfCodePair(11, (ViewDirection.X)));
            pairs.Add(new DxfCodePair(21, (ViewDirection.Y)));
            pairs.Add(new DxfCodePair(31, (ViewDirection.Z)));
            pairs.Add(new DxfCodePair(12, (TargetPoint.X)));
            pairs.Add(new DxfCodePair(22, (TargetPoint.Y)));
            pairs.Add(new DxfCodePair(32, (TargetPoint.Z)));
            pairs.Add(new DxfCodePair(42, EnsurePositiveOrDefault(1.0)(LensLength)));
            pairs.Add(new DxfCodePair(43, (FrontClippingPlane)));
            pairs.Add(new DxfCodePair(44, (BackClippingPlane)));
            pairs.Add(new DxfCodePair(50, (TwistAngle)));
            pairs.Add(new DxfCodePair(71, (ViewMode)));
            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(281, (short)(RenderMode)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(72, BoolShort(IsAssociatedUCSPresent)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(73, BoolShort(IsCameraPlottable)));
            }

            if (BackgroundObjectPointer != 0u && version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(332, UIntHandle(BackgroundObjectPointer)));
            }

            if (SelectionObjectPointer != 0u && version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(334, UIntHandle(SelectionObjectPointer)));
            }

            if (VisualStyleObjectPointer != 0u && version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(348, UIntHandle(VisualStyleObjectPointer)));
            }

            if (SunOwnershipPointer != 0u && version >= DxfAcadVersion.R2010)
            {
                pairs.Add(new DxfCodePair(361, UIntHandle(SunOwnershipPointer)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(110, (UCSOrigin.X)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(120, (UCSOrigin.Y)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(130, (UCSOrigin.Z)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(111, (UCSXAxis.X)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(121, (UCSXAxis.Y)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(131, (UCSXAxis.Z)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(112, (UCSYAxis.X)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(122, (UCSYAxis.Y)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(132, (UCSYAxis.Z)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(79, (short)(OrthographicViewType)));
            }

            if (IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(146, (UCSElevation)));
            }

            if (UCSHandle != 0u && IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(345, UIntHandle(UCSHandle)));
            }

            if (BaseUCSHandle != 0u && IsAssociatedUCSPresent && version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(346, UIntHandle(BaseUCSHandle)));
            }

            if (XData != null)
            {
                XData.AddValuePairs(pairs, version, outputHandles);
            }
        }

        internal static DxfView FromBuffer(DxfCodePairBufferReader buffer)
        {
            var item = new DxfView();
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
                    case 40:
                        item.ViewHeight = (pair.DoubleValue);
                        break;
                    case 10:
                        item.ViewCenterPoint = item.ViewCenterPoint.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 20:
                        item.ViewCenterPoint = item.ViewCenterPoint.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 41:
                        item.ViewWidth = (pair.DoubleValue);
                        break;
                    case 11:
                        item.ViewDirection = item.ViewDirection.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 21:
                        item.ViewDirection = item.ViewDirection.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 31:
                        item.ViewDirection = item.ViewDirection.WithUpdatedZ(pair.DoubleValue);
                        break;
                    case 12:
                        item.TargetPoint = item.TargetPoint.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 22:
                        item.TargetPoint = item.TargetPoint.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 32:
                        item.TargetPoint = item.TargetPoint.WithUpdatedZ(pair.DoubleValue);
                        break;
                    case 42:
                        item.LensLength = (pair.DoubleValue);
                        break;
                    case 43:
                        item.FrontClippingPlane = (pair.DoubleValue);
                        break;
                    case 44:
                        item.BackClippingPlane = (pair.DoubleValue);
                        break;
                    case 50:
                        item.TwistAngle = (pair.DoubleValue);
                        break;
                    case 71:
                        item.ViewMode = (pair.ShortValue);
                        break;
                    case 281:
                        item.RenderMode = (DxfViewRenderMode)(pair.ShortValue);
                        break;
                    case 72:
                        item.IsAssociatedUCSPresent = BoolShort(pair.ShortValue);
                        break;
                    case 73:
                        item.IsCameraPlottable = BoolShort(pair.ShortValue);
                        break;
                    case 332:
                        item.BackgroundObjectPointer = UIntHandle(pair.StringValue);
                        break;
                    case 334:
                        item.SelectionObjectPointer = UIntHandle(pair.StringValue);
                        break;
                    case 348:
                        item.VisualStyleObjectPointer = UIntHandle(pair.StringValue);
                        break;
                    case 361:
                        item.SunOwnershipPointer = UIntHandle(pair.StringValue);
                        break;
                    case 110:
                        item.UCSOrigin = item.UCSOrigin.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 120:
                        item.UCSOrigin = item.UCSOrigin.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 130:
                        item.UCSOrigin = item.UCSOrigin.WithUpdatedZ(pair.DoubleValue);
                        break;
                    case 111:
                        item.UCSXAxis = item.UCSXAxis.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 121:
                        item.UCSXAxis = item.UCSXAxis.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 131:
                        item.UCSXAxis = item.UCSXAxis.WithUpdatedZ(pair.DoubleValue);
                        break;
                    case 112:
                        item.UCSYAxis = item.UCSYAxis.WithUpdatedX(pair.DoubleValue);
                        break;
                    case 122:
                        item.UCSYAxis = item.UCSYAxis.WithUpdatedY(pair.DoubleValue);
                        break;
                    case 132:
                        item.UCSYAxis = item.UCSYAxis.WithUpdatedZ(pair.DoubleValue);
                        break;
                    case 79:
                        item.OrthographicViewType = (DxfOrthographicViewType)(pair.ShortValue);
                        break;
                    case 146:
                        item.UCSElevation = (pair.DoubleValue);
                        break;
                    case 345:
                        item.UCSHandle = UIntHandle(pair.StringValue);
                        break;
                    case 346:
                        item.BaseUCSHandle = UIntHandle(pair.StringValue);
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
