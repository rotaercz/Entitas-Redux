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

    public ExampleContent.VisualDebugging.Array3DComponent Array3D { get { return (ExampleContent.VisualDebugging.Array3DComponent)GetComponent(VisualDebugComponentsLookup.Array3D); } }
    public bool HasArray3D { get { return HasComponent(VisualDebugComponentsLookup.Array3D); } }

    public void AddArray3D(string[,,] newArray3d) {
        var index = VisualDebugComponentsLookup.Array3D;
        var component = (ExampleContent.VisualDebugging.Array3DComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Array3DComponent));
        component.array3d = newArray3d;
        AddComponent(index, component);
    }

    public void ReplaceArray3D(string[,,] newArray3d) {
        var index = VisualDebugComponentsLookup.Array3D;
        var component = (ExampleContent.VisualDebugging.Array3DComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Array3DComponent));
        component.array3d = newArray3d;
        ReplaceComponent(index, component);
    }

	public void CopyArray3DTo(ExampleContent.VisualDebugging.Array3DComponent copyComponent) {
        var index = VisualDebugComponentsLookup.Array3D;
        var component = (ExampleContent.VisualDebugging.Array3DComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Array3DComponent));
        component.array3d = (string[,,])copyComponent.array3d.Clone();
        ReplaceComponent(index, component);
    }

    public void RemoveArray3D() {
        RemoveComponent(VisualDebugComponentsLookup.Array3D);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherArray3D;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Array3D {
        get {
            if (_matcherArray3D == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Array3D);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherArray3D = matcher;
            }

            return _matcherArray3D;
        }
    }
}
