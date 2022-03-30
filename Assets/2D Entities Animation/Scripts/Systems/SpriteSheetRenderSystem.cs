using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

namespace EntitiesAnimation 
{


    [UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
    public partial class SpriteSheetRenderSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((ref RenderIndex renderIndex, ref TileCount tileCount, in SpriteSheetComponent spriteSheetComponent) => {
                renderIndex.Value = spriteSheetComponent.renderIndex;
                tileCount.Value = spriteSheetComponent.tileCount;
            }).Schedule();
        }
    }
}
