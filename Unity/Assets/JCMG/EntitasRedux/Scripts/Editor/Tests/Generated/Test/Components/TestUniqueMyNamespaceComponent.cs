//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestContext {

    public TestEntity UniqueMyNamespaceEntity { get { return GetGroup(TestMatcher.UniqueMyNamespace).GetSingleEntity(); } }
    public EntitasRedux.Tests.UniqueMyNamespaceComponent UniqueMyNamespace { get { return UniqueMyNamespaceEntity.UniqueMyNamespace; } }
    public bool HasUniqueMyNamespace { get { return UniqueMyNamespaceEntity != null; } }

    public TestEntity SetUniqueMyNamespace(string newValue) {
        if (HasUniqueMyNamespace) {
            throw new JCMG.EntitasRedux.EntitasReduxException("Could not set UniqueMyNamespace!\n" + this + " already has an entity with EntitasRedux.Tests.UniqueMyNamespaceComponent!",
                "You should check if the context already has a UniqueMyNamespaceEntity before setting it or use context.ReplaceUniqueMyNamespace().");
        }
        var entity = CreateEntity();
        entity.AddUniqueMyNamespace(newValue);
        return entity;
    }

    public void ReplaceUniqueMyNamespace(string newValue) {
        var entity = UniqueMyNamespaceEntity;
        if (entity == null) {
            entity = SetUniqueMyNamespace(newValue);
        } else {
            entity.ReplaceUniqueMyNamespace(newValue);
        }
    }

    public void RemoveUniqueMyNamespace() {
        UniqueMyNamespaceEntity.Destroy();
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
public partial class TestEntity {

    public EntitasRedux.Tests.UniqueMyNamespaceComponent UniqueMyNamespace { get { return (EntitasRedux.Tests.UniqueMyNamespaceComponent)GetComponent(TestComponentsLookup.UniqueMyNamespace); } }
    public bool HasUniqueMyNamespace { get { return HasComponent(TestComponentsLookup.UniqueMyNamespace); } }

    public void AddUniqueMyNamespace(string newValue) {
        var index = TestComponentsLookup.UniqueMyNamespace;
        var component = (EntitasRedux.Tests.UniqueMyNamespaceComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueMyNamespaceComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUniqueMyNamespace(string newValue) {
        var index = TestComponentsLookup.UniqueMyNamespace;
        var component = (EntitasRedux.Tests.UniqueMyNamespaceComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueMyNamespaceComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

	public void CopyUniqueMyNamespaceTo(EntitasRedux.Tests.UniqueMyNamespaceComponent copyComponent) {
        var index = TestComponentsLookup.UniqueMyNamespace;
        var component = (EntitasRedux.Tests.UniqueMyNamespaceComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueMyNamespaceComponent));
        component.value = copyComponent.value;
        ReplaceComponent(index, component);
    }

    public void RemoveUniqueMyNamespace() {
        RemoveComponent(TestComponentsLookup.UniqueMyNamespace);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherUniqueMyNamespace;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> UniqueMyNamespace {
        get {
            if (_matcherUniqueMyNamespace == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.UniqueMyNamespace);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherUniqueMyNamespace = matcher;
            }

            return _matcherUniqueMyNamespace;
        }
    }
}