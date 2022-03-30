using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

namespace EntitiesAnimation
{
    public partial class TestAnimationSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            float deltaTime = Time.DeltaTime;

            Entities.ForEach((ref SpriteSheetComponent spriteSheetComponent) => {
                // Hard coded values
                //if ((spriteSheetComponent.renderIndex.x + 1) % spriteSheetComponent.tileCount.x == 0){
                //    spriteSheetComponent.renderIndex.y = (spriteSheetComponent.renderIndex.y + 1) % spriteSheetComponent.tileCount.y;
                //}
                spriteSheetComponent.renderIndex += new float2(1, 1) * deltaTime;//((spriteSheetComponent.renderIndex.x + 1) % spriteSheetComponent.tileCount.x, spriteSheetComponent.renderIndex.y);
            }).Schedule();
        }
    }
}

