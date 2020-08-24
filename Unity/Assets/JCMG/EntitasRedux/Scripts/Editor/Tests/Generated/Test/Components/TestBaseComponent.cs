//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public EntitasRedux.Tests.BaseComponent Base { get { return (EntitasRedux.Tests.BaseComponent)GetComponent(TestComponentsLookup.Base); } }
    public bool HasBase { get { return HasComponent(TestComponentsLookup.Base); } }

    public void AddBase(int newValue) {
        var index = TestComponentsLookup.Base;
        var component = (EntitasRedux.Tests.BaseComponent)CreateComponent(index, typeof(EntitasRedux.Tests.BaseComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBase(int newValue) {
        var index = TestComponentsLookup.Base;
        var component = (EntitasRedux.Tests.BaseComponent)CreateComponent(index, typeof(EntitasRedux.Tests.BaseComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

	public void CopyBaseTo(EntitasRedux.Tests.BaseComponent copyComponent) {
        var index = TestComponentsLookup.Base;
        var component = (EntitasRedux.Tests.BaseComponent)CreateComponent(index, typeof(EntitasRedux.Tests.BaseComponent));
        component.value = copyComponent.value;
        ReplaceComponent(index, component);
    }

    public void RemoveBase() {
        RemoveComponent(TestComponentsLookup.Base);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherBase;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> Base {
        get {
            if (_matcherBase == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.Base);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherBase = matcher;
            }

            return _matcherBase;
        }
    }
}
