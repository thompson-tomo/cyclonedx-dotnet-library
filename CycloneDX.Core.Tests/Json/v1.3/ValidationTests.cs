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
using System.Threading.Tasks;
using Xunit;
using CycloneDX.Json;

namespace CycloneDX.Tests.Json.v1_3
{
    public class ValidationTests
    {
        [Theory]
        [InlineData("valid-assembly-1.3.json")]
        //TODO: figure out what is going wrong with this one 
        //[InlineData("valid-bom-1.3.json")]
        [InlineData("valid-component-hashes-1.3.json")]
        [InlineData("valid-component-ref-1.3.json")]
        [InlineData("valid-component-swid-1.3.json")]
        [InlineData("valid-component-swid-full-1.3.json")]
        [InlineData("valid-component-types-1.3.json")]
        [InlineData("valid-compositions-1.3.json")]
        [InlineData("valid-dependency-1.3.json")]
        [InlineData("valid-empty-components-1.3.json")]
        [InlineData("valid-evidence-1.3.json")]
        [InlineData("valid-external-reference-1.3.json")]
        [InlineData("valid-license-expression-1.3.json")]
        [InlineData("valid-license-id-1.3.json")]
        [InlineData("valid-license-name-1.3.json")]
        [InlineData("valid-metadata-author-1.3.json")]
        [InlineData("valid-metadata-license-1.3.json")]
        [InlineData("valid-metadata-manufacture-1.3.json")]
        [InlineData("valid-metadata-supplier-1.3.json")]
        [InlineData("valid-metadata-timestamp-1.3.json")]
        [InlineData("valid-metadata-tool-1.3.json")]
        [InlineData("valid-minimal-viable-1.3.json")]
        [InlineData("valid-patch-1.3.json")]
        [InlineData("valid-properties-1.3.json")]
        [InlineData("valid-service-1.3.json")]
        [InlineData("valid-service-empty-objects-1.3.json")]
         public async Task ValidJsonTest(string filename)
         {
             var resourceFilename = Path.Join("Resources", "v1.3", filename);
             var jsonBom = File.ReadAllText(resourceFilename);

             var validationResult = await Validator.Validate(jsonBom, SchemaVersion.v1_3);

             Assert.True(validationResult.Valid);
        }
    }
}
