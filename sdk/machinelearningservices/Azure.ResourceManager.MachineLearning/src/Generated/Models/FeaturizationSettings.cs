// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Featurization Configuration. </summary>
    public partial class FeaturizationSettings
    {
        /// <summary> Initializes a new instance of FeaturizationSettings. </summary>
        public FeaturizationSettings()
        {
        }

        /// <summary> Initializes a new instance of FeaturizationSettings. </summary>
        /// <param name="datasetLanguage"> Dataset language, useful for the text data. </param>
        internal FeaturizationSettings(string datasetLanguage)
        {
            DatasetLanguage = datasetLanguage;
        }

        /// <summary> Dataset language, useful for the text data. </summary>
        public string DatasetLanguage { get; set; }
    }
}
