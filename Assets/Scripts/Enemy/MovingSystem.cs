using Scellecs.Morpeh;
using Scellecs.Morpeh.Helpers;
using Scellecs.Morpeh.Systems;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Enemy
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    [CreateAssetMenu(menuName = "ECS/Systems/" + nameof(MovingSystem))]
    public class MovingSystem: SimpleUpdateSystem<EnemyComponent>
    {
        protected override void Process(Entity entity, ref EnemyComponent component, in float deltaTime)
        {
            var cosAnglePos = Vector3.Dot(component.Transform.position.normalized, Vector3.forward);
            var sinAnglePos = Mathf.Pow(1 - cosAnglePos, 0.5f);

            // var position = new Vector3(sinAnglePos + deltaTime*0.01f, 0, cosAnglePos + deltaTime*0.01f);
            component.Angle += deltaTime;
            var position = new Vector3(Mathf.Cos(component.Angle), 0, Mathf.Sin(component.Angle));

            component.Transform.position = position;
        }
    }
}