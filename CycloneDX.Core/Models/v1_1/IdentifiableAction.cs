﻿// This file is part of CycloneDX Library for .NET
//
// Licensed under the Apache License, Version 2.0 (the “License”);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an “AS IS” BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SPDX-License-Identifier: Apache-2.0
// Copyright (c) Steve Springett. All Rights Reserved.

using System;
using System.Xml.Serialization;

namespace CycloneDX.Models.v1_1
{
    public class IdentifiableAction
    {
        [XmlElement("timestamp")]
        public DateTime? Timestamp { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("email")]
        public string Email { get; set; }

        public IdentifiableAction() {}

        public IdentifiableAction(v1_2.IdentifiableAction identifiableAction)
        {
            Timestamp = identifiableAction.Timestamp;
            Name = identifiableAction.Name;
            Email = identifiableAction.Email;
        }
    }
}
