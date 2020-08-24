//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity {

    public EntitasRedux.Tests.NameAgeComponent NameAge { get { return (EntitasRedux.Tests.NameAgeComponent)GetComponent(Test2ComponentsLookup.NameAge); } }
    public bool HasNameAge { get { return HasComponent(Test2ComponentsLookup.NameAge); } }

    public void AddNameAge(string newName, int newAge) {
        var index = Test2ComponentsLookup.NameAge;
        var component = (EntitasRedux.Tests.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.NameAgeComponent));
        component.name = newName;
        component.age = newAge;
        AddComponent(index, component);
    }

    public void ReplaceNameAge(string newName, int newAge) {
        var index = Test2ComponentsLookup.NameAge;
        var component = (EntitasRedux.Tests.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.NameAgeComponent));
        component.name = newName;
        component.age = newAge;
        ReplaceComponent(index, component);
    }

	public void CopyNameAgeTo(EntitasRedux.Tests.NameAgeComponent copyComponent) {
        var index = Test2ComponentsLookup.NameAge;
        var component = (EntitasRedux.Tests.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.NameAgeComponent));
        component.name = copyComponent.name;
        component.age = copyComponent.age;
        ReplaceComponent(index, component);
    }

    public void RemoveNameAge() {
        RemoveComponent(Test2ComponentsLookup.NameAge);
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
public partial class Test2Entity : INameAgeEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test2Matcher {

    static JCMG.EntitasRedux.IMatcher<Test2Entity> _matcherNameAge;

    public static JCMG.EntitasRedux.IMatcher<Test2Entity> NameAge {
        get {
            if (_matcherNameAge == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<Test2Entity>)JCMG.EntitasRedux.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.NameAge);
                matcher.ComponentNames = Test2ComponentsLookup.ComponentNames;
                _matcherNameAge = matcher;
            }

            return _matcherNameAge;
        }
    }
}
