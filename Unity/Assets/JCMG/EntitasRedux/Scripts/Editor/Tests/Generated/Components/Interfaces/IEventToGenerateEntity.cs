//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IEventToGenerateEntity {

    EventToGenerateComponent EventToGenerate { get; }
    bool hasEventToGenerate { get; }

    void AddEventToGenerate(EntitasRedux.Tests.EventToGenerate newValue);
    void ReplaceEventToGenerate(EntitasRedux.Tests.EventToGenerate newValue);
    void RemoveEventToGenerate();
}