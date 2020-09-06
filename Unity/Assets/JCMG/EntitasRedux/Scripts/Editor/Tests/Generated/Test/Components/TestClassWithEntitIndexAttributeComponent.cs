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

    public ClassWithEntitIndexAttributeComponent ClassWithEntitIndexAttribute { get { return (ClassWithEntitIndexAttributeComponent)GetComponent(TestComponentsLookup.ClassWithEntitIndexAttribute); } }
    public bool HasClassWithEntitIndexAttribute { get { return HasComponent(TestComponentsLookup.ClassWithEntitIndexAttribute); } }

    public void AddClassWithEntitIndexAttribute(EntitasRedux.Tests.ClassWithEntitIndexAttribute newValue) {
        var index = TestComponentsLookup.ClassWithEntitIndexAttribute;
        var component = (ClassWithEntitIndexAttributeComponent)CreateComponent(index, typeof(ClassWithEntitIndexAttributeComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceClassWithEntitIndexAttribute(EntitasRedux.Tests.ClassWithEntitIndexAttribute newValue) {
        var index = TestComponentsLookup.ClassWithEntitIndexAttribute;
        var component = (ClassWithEntitIndexAttributeComponent)CreateComponent(index, typeof(ClassWithEntitIndexAttributeComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

	public void CopyClassWithEntitIndexAttributeTo(ClassWithEntitIndexAttributeComponent copyComponent) {
        var index = TestComponentsLookup.ClassWithEntitIndexAttribute;
        var component = (ClassWithEntitIndexAttributeComponent)CreateComponent(index, typeof(ClassWithEntitIndexAttributeComponent));
        component.value = copyComponent.value;
        ReplaceComponent(index, component);
    }

    public void RemoveClassWithEntitIndexAttribute() {
        RemoveComponent(TestComponentsLookup.ClassWithEntitIndexAttribute);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherClassWithEntitIndexAttribute;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> ClassWithEntitIndexAttribute {
        get {
            if (_matcherClassWithEntitIndexAttribute == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.ClassWithEntitIndexAttribute);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherClassWithEntitIndexAttribute = matcher;
            }

            return _matcherClassWithEntitIndexAttribute;
        }
    }
}