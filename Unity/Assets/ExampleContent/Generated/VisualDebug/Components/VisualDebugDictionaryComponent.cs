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

    public ExampleContent.VisualDebugging.DictionaryComponent Dictionary { get { return (ExampleContent.VisualDebugging.DictionaryComponent)GetComponent(VisualDebugComponentsLookup.Dictionary); } }
    public bool HasDictionary { get { return HasComponent(VisualDebugComponentsLookup.Dictionary); } }

    public void AddDictionary(System.Collections.Generic.Dictionary<string, string> newDict) {
        var index = VisualDebugComponentsLookup.Dictionary;
        var component = (ExampleContent.VisualDebugging.DictionaryComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictionaryComponent));
        component.dict = newDict;
        AddComponent(index, component);
    }

    public void ReplaceDictionary(System.Collections.Generic.Dictionary<string, string> newDict) {
        var index = VisualDebugComponentsLookup.Dictionary;
        var component = (ExampleContent.VisualDebugging.DictionaryComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictionaryComponent));
        component.dict = newDict;
        ReplaceComponent(index, component);
    }

	public void CopyDictionaryTo(ExampleContent.VisualDebugging.DictionaryComponent copyComponent) {
        var index = VisualDebugComponentsLookup.Dictionary;
        var component = (ExampleContent.VisualDebugging.DictionaryComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictionaryComponent));
        component.dict = (System.Collections.Generic.Dictionary<string, string>)JCMG.EntitasRedux.DictionaryTools.ShallowCopy(copyComponent.dict);
        ReplaceComponent(index, component);
    }

    public void RemoveDictionary() {
        RemoveComponent(VisualDebugComponentsLookup.Dictionary);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherDictionary;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Dictionary {
        get {
            if (_matcherDictionary == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Dictionary);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherDictionary = matcher;
            }

            return _matcherDictionary;
        }
    }
}