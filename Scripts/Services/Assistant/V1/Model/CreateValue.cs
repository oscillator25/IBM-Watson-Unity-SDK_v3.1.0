/**
* Copyright 2018, 2019 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.Watson.Assistant.V1.Model
{
    /// <summary>
    /// CreateValue.
    /// </summary>
    public class CreateValue
    {
        /// <summary>
        /// Specifies the type of value.
        /// </summary>
        public class ValueTypeValue
        {
            /// <summary>
            /// Constant SYNONYMS for synonyms
            /// </summary>
            public const string SYNONYMS = "synonyms";
            /// <summary>
            /// Constant PATTERNS for patterns
            /// </summary>
            public const string PATTERNS = "patterns";
            
        }

        /// <summary>
        /// Specifies the type of value.
        /// Constants for possible values can be found using CreateValue.ValueTypeValue
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueType { get; set; }
        /// <summary>
        /// The text of the entity value. This string must conform to the following restrictions:
        /// - It cannot contain carriage return, newline, or tab characters.
        /// - It cannot consist of only whitespace characters.
        /// - It must be no longer than 64 characters.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
        /// <summary>
        /// Any metadata related to the entity value.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public object Metadata { get; set; }
        /// <summary>
        /// An array containing any synonyms for the entity value. You can provide either synonyms or patterns (as
        /// indicated by **type**), but not both. A synonym must conform to the following restrictions:
        /// - It cannot contain carriage return, newline, or tab characters.
        /// - It cannot consist of only whitespace characters.
        /// - It must be no longer than 64 characters.
        /// </summary>
        [JsonProperty("synonyms", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Synonyms { get; set; }
        /// <summary>
        /// An array of patterns for the entity value. You can provide either synonyms or patterns (as indicated by
        /// **type**), but not both. A pattern is a regular expression no longer than 512 characters. For more
        /// information about how to specify a pattern, see the
        /// [documentation](https://cloud.ibm.com/docs/services/assistant/entities.html#creating-entities).
        /// </summary>
        [JsonProperty("patterns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Patterns { get; set; }
    }
}
