//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public EntitasRedux.Tests.StandardComponent Standard { get { return (EntitasRedux.Tests.StandardComponent)GetComponent(TestComponentsLookup.Standard); } }
    public bool HasStandard { get { return HasComponent(TestComponentsLookup.Standard); } }

    public void AddStandard(string newValue) {
        var index = TestComponentsLookup.Standard;
        var component = (EntitasRedux.Tests.StandardComponent)CreateComponent(index, typeof(EntitasRedux.Tests.StandardComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStandard(string newValue) {
        var index = TestComponentsLookup.Standard;
        var component = (EntitasRedux.Tests.StandardComponent)CreateComponent(index, typeof(EntitasRedux.Tests.StandardComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStandard() {
        RemoveComponent(TestComponentsLookup.Standard);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherStandard;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> Standard {
        get {
            if (_matcherStandard == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.Standard);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherStandard = matcher;
            }

            return _matcherStandard;
        }
    }
}
