// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// AutoML vertical class.
    /// Base class for AutoML verticals - TableVertical/ImageVertical/NLPVertical
    /// Please note <see cref="AutoMLVertical"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ClassificationTask"/>, <see cref="MachineLearningForecasting"/>, <see cref="ImageClassification"/>, <see cref="ImageClassificationMultilabel"/>, <see cref="ImageInstanceSegmentation"/>, <see cref="ImageObjectDetection"/>, <see cref="AutoMLVerticalRegression"/>, <see cref="TextClassification"/>, <see cref="TextClassificationMultilabel"/> and <see cref="TextNer"/>.
    /// </summary>
    public abstract partial class AutoMLVertical
    {
        /// <summary> Initializes a new instance of <see cref="AutoMLVertical"/>. </summary>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> is null. </exception>
        protected AutoMLVertical(MachineLearningTableJobInput trainingData)
        {
            Argument.AssertNotNull(trainingData, nameof(trainingData));

            TrainingData = trainingData;
        }

        /// <summary> Initializes a new instance of <see cref="AutoMLVertical"/>. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="trainingData"> [Required] Training data input. </param>
        internal AutoMLVertical(MachineLearningLogVerbosity? logVerbosity, string targetColumnName, TaskType taskType, MachineLearningTableJobInput trainingData)
        {
            LogVerbosity = logVerbosity;
            TargetColumnName = targetColumnName;
            TaskType = taskType;
            TrainingData = trainingData;
        }

        /// <summary> Log verbosity for the job. </summary>
        public MachineLearningLogVerbosity? LogVerbosity { get; set; }
        /// <summary>
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </summary>
        public string TargetColumnName { get; set; }
        /// <summary> [Required] Task type for AutoMLJob. </summary>
        internal TaskType TaskType { get; set; }
        /// <summary> [Required] Training data input. </summary>
        public MachineLearningTableJobInput TrainingData { get; set; }
    }
}
