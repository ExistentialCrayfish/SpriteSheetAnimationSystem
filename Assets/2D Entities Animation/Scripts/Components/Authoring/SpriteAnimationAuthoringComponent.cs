using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;


namespace EntitiesAnimation
{
    [DisallowMultipleComponent]
    public class SpriteAnimationAuthoringComponent : MonoBehaviour, IConvertGameObjectToEntity
    {
        [Tooltip("How many rows and columns are present on the sprite sheet. If there are 4x4 sprites in the sheet, you'd enter x: 4, y: 4")]
        public float2 rowColumnCount;

        [Tooltip("The current row/column index that should be rendered ([0, 0] is the top left tile)")]
        public float2 renderIndex;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponentData(entity, new SpriteSheetComponent { tileCount = rowColumnCount, renderIndex = renderIndex });

            // Required for rendering
            dstManager.AddComponentData(entity, new RenderIndex { Value = renderIndex });
            dstManager.AddComponentData(entity, new TileCount { Value = rowColumnCount });
        }
    }
}