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
// Copyright (c) Steve Springett. All Rights Reserved.

using System;
using System.IO;
using Xunit;
using Snapshooter;
using Snapshooter.Xunit;

namespace CycloneDX.Tests.Models.v1_1
{
    public class Tests
    {
        [Theory]
        [InlineData("valid-bom-1.0.xml")]
        [InlineData("valid-component-hashes-1.0.xml")]
        public void BomConversionTest_v1_0_to_v1_1_Test(string filename)
        {
            var resourceFilename = Path.Join("Resources", "v1.0", filename);
            var xmlBom = File.ReadAllText(resourceFilename);

            var bom = CycloneDX.Xml.Deserializer.Deserialize_v1_0(xmlBom);
            var actualBom = new CycloneDX.Models.v1_1.Bom(bom);
            xmlBom = CycloneDX.Xml.Serializer.Serialize(actualBom);

            Snapshot.Match(xmlBom, SnapshotNameExtension.Create(filename));
        }

        [Theory]
        [InlineData("valid-assembly-1.2.xml")]
        [InlineData("valid-bom-1.2.xml")]
        [InlineData("valid-component-hashes-1.2.xml")]
        [InlineData("valid-component-ref-1.2.xml")]
        [InlineData("valid-component-swid-1.2.xml")]
        [InlineData("valid-component-swid-full-1.2.xml")]
        [InlineData("valid-component-types-1.2.xml")]
        [InlineData("valid-dependency-1.2.xml")]
        [InlineData("valid-empty-components-1.2.xml")]
        // [InlineData("valid-external-elements-1.2.xml")]
        [InlineData("valid-license-expression-1.2.xml")]
        [InlineData("valid-license-id-1.2.xml")]
        [InlineData("valid-license-name-1.2.xml")]
        [InlineData("valid-metadata-author-1.2.xml")]
        [InlineData("valid-metadata-manufacture-1.2.xml")]
        [InlineData("valid-metadata-supplier-1.2.xml")]
        [InlineData("valid-metadata-timestamp-1.2.xml")]
        [InlineData("valid-metadata-tool-1.2.xml")]
        [InlineData("valid-minimal-viable-1.2.xml")]
        [InlineData("valid-patch-1.2.xml")]
        // [InlineData("valid-random-attributes-1.2.xml")]
        [InlineData("valid-service-1.2.xml")]
        [InlineData("valid-service-empty-objects-1.2.xml")]
        // [InlineData("valid-xml-signature-1.2.xml")]
        public void BomConversionTest_v1_2_to_v1_1_Test(string filename)
        {
            var resourceFilename = Path.Join("Resources", "v1.2", filename);
            var xmlBom = File.ReadAllText(resourceFilename);

            var bom = CycloneDX.Xml.Deserializer.Deserialize_v1_2(xmlBom);
            var actualBom = new CycloneDX.Models.v1_1.Bom(bom);
            xmlBom = CycloneDX.Xml.Serializer.Serialize(actualBom);

            Snapshot.Match(xmlBom, SnapshotNameExtension.Create(filename));
        }
    }
}
