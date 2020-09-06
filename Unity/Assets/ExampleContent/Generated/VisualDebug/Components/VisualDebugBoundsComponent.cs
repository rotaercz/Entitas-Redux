//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public ExampleContent.VisualDebugging.BoundsComponent Bounds { get { return (ExampleContent.VisualDebugging.BoundsComponent)GetComponent(VisualDebugComponentsLookup.Bounds); } }
    public bool HasBounds { get { return HasComponent(VisualDebugComponentsLookup.Bounds); } }

    public void AddBounds(UnityEngine.Bounds newBounds) {
        var index = VisualDebugComponentsLookup.Bounds;
        var component = (ExampleContent.VisualDebugging.BoundsComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.BoundsComponent));
        component.bounds = newBounds;
        AddComponent(index, component);
    }

    public void ReplaceBounds(UnityEngine.Bounds newBounds) {
        var index = VisualDebugComponentsLookup.Bounds;
        var component = (ExampleContent.VisualDebugging.BoundsComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.BoundsComponent));
        component.bounds = newBounds;
        ReplaceComponent(index, component);
    }

	public void CopyBoundsTo(ExampleContent.VisualDebugging.BoundsComponent copyComponent) {
        var index = VisualDebugComponentsLookup.Bounds;
        var component = (ExampleContent.VisualDebugging.BoundsComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.BoundsComponent));
        component.bounds = copyComponent.bounds;
        ReplaceComponent(index, component);
    }

    public void RemoveBounds() {
        RemoveComponent(VisualDebugComponentsLookup.Bounds);
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
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherBounds;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Bounds {
        get {
            if (_matcherBounds == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Bounds);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherBounds = matcher;
            }

            return _matcherBounds;
        }
    }
}