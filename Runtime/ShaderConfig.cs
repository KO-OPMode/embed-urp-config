//-----------------------------------------------------------------------------
// Configuration
//-----------------------------------------------------------------------------
using System;

namespace UnityEngine.Rendering.Universal
{
    /// <summary>
    /// Project-wide shader configuration options.
    /// </summary>
    /// <remarks>This enum will generate the proper shader defines.</remarks>
    ///<seealso cref="ShaderConfig"/>
    [GenerateHLSL]
    public static class ShaderOptions
    {
        /// <summary>Max number of lights supported on mobile with OpenGL 3.0 and below.</summary>
        public const int k_MaxVisibleLightCountLowEndMobile = 16;

        /// <summary>Max number of lights supported on mobile, OpenGL, and WebGPU platforms.</summary>
        public const int k_MaxVisibleLightCountMobile = 32;

        // ys custom start
        // Reduce our number of lights on desktop to 256 to optimize shader build times
        /// <summary>Max number of lights supported on desktop platforms.</summary>
        public const int k_MaxVisibleLightCountDesktop = 32;
        // ys custom end
    };
}
