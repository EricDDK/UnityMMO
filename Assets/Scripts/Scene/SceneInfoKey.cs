using XLua;

namespace UnityMMO
{
[Hotfix]
[LuaCallCSharp]
public enum SceneInfoKey
{
    None=0,
    EnterView=1,//value is scene object type
    LeaveView=2,
    PosChange=3,
    TargetPos=4,
    JumpState=5,
}

[Hotfix]
[LuaCallCSharp]
public enum SceneObjectType
{
    None=0,
    Role=1,
    Monster=2,
    NPC=3,
    DropItem=4,//掉落物
}
}