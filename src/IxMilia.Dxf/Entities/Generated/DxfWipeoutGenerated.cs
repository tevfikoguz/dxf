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
    /// DxfWipeout class
    /// </summary>
    public partial class DxfWipeout : DxfImage
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.WipeOut; } }
        protected override DxfAcadVersion MinVersion { get { return DxfAcadVersion.R2000; } }

        public DxfWipeout()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbWipeout"));
        }
    }
}