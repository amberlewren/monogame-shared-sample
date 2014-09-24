#region File Description
//-----------------------------------------------------------------------------
// Keyframe.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline.Processors;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
#endregion

namespace SkinnedModelPipeline
{
    /// <summary>
    /// Describes the position of a single bone at a single point in time.
    /// </summary>
    [ContentSerializerRuntimeType("SkinnedModel.Keyframe, SkinnedModel")]
    public class Keyframe
    {
        /// <summary>
        /// Constructs a new keyframe object.
        /// </summary>
        public Keyframe(int bone, TimeSpan time, Matrix transform)
        {
            Bone = bone;
            Time = time;
            Transform = transform;
        }


        /// <summary>
        /// Private constructor for use by the XNB deserializer.
        /// </summary>
        private Keyframe()
        {
        }


        /// <summary>
        /// Gets the index of the target bone that is animated by this keyframe.
        /// </summary>
        [ContentSerializer]
        public int Bone { get; private set; }


        /// <summary>
        /// Gets the time offset from the start of the animation to this keyframe.
        /// </summary>
        [ContentSerializer]
        public TimeSpan Time { get; private set; }


        /// <summary>
        /// Gets the bone transform for this keyframe.
        /// </summary>
        [ContentSerializer]
        public Matrix Transform { get; private set; }
    }
}
