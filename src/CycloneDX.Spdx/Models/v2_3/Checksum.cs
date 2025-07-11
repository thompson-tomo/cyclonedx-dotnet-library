// This file is part of CycloneDX Library for .NET
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
// Copyright (c) OWASP Foundation. All Rights Reserved.

using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace CycloneDX.Spdx.Models.v2_3
{
    public class Checksum
    {
        /// <summary>
        /// Identifies the algorithm used to produce the subject Checksum. Currently, SHA-1 is the only supported algorithm. It is anticipated that other algorithms will be supported at a later time.
        /// </summary>
        [XmlElement("algorithm")]
        public ChecksumAlgorithm Algorithm { get; set; }

        /// <summary>
        /// The checksumValue property provides a lower case hexidecimal encoded digest value produced using a specific algorithm.
        /// </summary>
        [XmlElement("checksumValue")]
        public string ChecksumValue { get; set; }
    }
}
