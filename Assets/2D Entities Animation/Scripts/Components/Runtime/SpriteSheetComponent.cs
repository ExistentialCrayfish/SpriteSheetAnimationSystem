using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

namespace EntitiesAnimation
{
    [Serializable]
    public struct SpriteSheetComponent : IComponentData
    {
        public float2 renderIndex;
        public float2 tileCount;
    }

    /* Material Property Overrides. These are direct references to shader properites set in Shader Graph. */


    // Render Index - the current index to render (so a value of 0, 1 would render the sprite in the first column, second row. This is calculated based on the tile size.)

    [MaterialProperty("_RenderIndex", MaterialPropertyFormat.Float2)]
    public struct RenderIndex : IComponentData
    {
        public float2 Value;
    }

    // Tile Count - the amount of tiles along the rows and columns. For a 4x4 spritesheet (as per the example spritesheet), you'd input x: 4, y: 4.
    // The shader will automatically calculate how the image will be split, so this is all we need
    [MaterialProperty("_TileCount", MaterialPropertyFormat.Float2)]
    public struct TileCount : IComponentData
    {
        public float2 Value;
    }
}