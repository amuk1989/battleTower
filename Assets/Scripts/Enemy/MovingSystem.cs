using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Enemy
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    [CreateAssetMenu(menuName = "ECS/Systems/" + nameof(MovingSystem))]
    public class MovingSystem
    {
        
    }
}