using Scellecs.Morpeh;
using Scellecs.Morpeh.Helpers;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Moving
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    [CreateAssetMenu(menuName = "ECS/Systems/" + nameof(MovingSystem))]
    public class MovingSystem: SimpleUpdateSystem<MovingComponent>
    {
        protected override void Process(Entity entity, ref MovingComponent component, in float deltaTime)
        {
            component.Angle += deltaTime;
            
            var position = new Vector3(Mathf.Cos(component.Angle), 0, Mathf.Sin(component.Angle));

            component.Transform.position = position;
        }
    }
}