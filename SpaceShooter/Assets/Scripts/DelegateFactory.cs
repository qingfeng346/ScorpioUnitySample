using System;
using System.Collections.Generic;
using Scorpio;
public class DelegateFactory : IDelegateFactory {
    public static void Initialize(Script script) {
        ScorpioDelegateFactory.SetFactory(new DelegateFactory());
    }
    public Delegate CreateDelegate(Type delegateType, ScriptObject scriptObject) {
        if (delegateType == typeof(System.Action))
            return new System.Action( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(System.Action<System.Boolean,System.Boolean,System.Int32>))
            return new System.Action<System.Boolean,System.Boolean,System.Int32>( (arg0,arg1,arg2) => { scriptObject.call(ScriptValue.Null,arg0,arg1,arg2); } );
        if (delegateType == typeof(System.Action<System.Boolean,System.String>))
            return new System.Action<System.Boolean,System.String>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(System.Action<System.Boolean>))
            return new System.Action<System.Boolean>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<System.Int32,System.String>))
            return new System.Action<System.Int32,System.String>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(System.Action<System.String,System.Action<UnityEngine.U2D.SpriteAtlas>>))
            return new System.Action<System.String,System.Action<UnityEngine.U2D.SpriteAtlas>>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(System.Action<System.String,System.Boolean>))
            return new System.Action<System.String,System.Boolean>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(System.Action<UnityEngine.AsyncOperation>))
            return new System.Action<UnityEngine.AsyncOperation>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Camera[]>))
            return new System.Action<UnityEngine.Camera[]>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Camera>))
            return new System.Action<UnityEngine.Camera>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Cubemap>))
            return new System.Action<UnityEngine.Cubemap>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Experimental.XR.FrameReceivedEventArgs>))
            return new System.Action<UnityEngine.Experimental.XR.FrameReceivedEventArgs>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Experimental.XR.MeshGenerationResult>))
            return new System.Action<UnityEngine.Experimental.XR.MeshGenerationResult>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Experimental.XR.PlaneAddedEventArgs>))
            return new System.Action<UnityEngine.Experimental.XR.PlaneAddedEventArgs>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Experimental.XR.PlaneRemovedEventArgs>))
            return new System.Action<UnityEngine.Experimental.XR.PlaneRemovedEventArgs>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Experimental.XR.PlaneUpdatedEventArgs>))
            return new System.Action<UnityEngine.Experimental.XR.PlaneUpdatedEventArgs>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Experimental.XR.PointCloudUpdatedEventArgs>))
            return new System.Action<UnityEngine.Experimental.XR.PointCloudUpdatedEventArgs>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Experimental.XR.ReferencePointUpdatedEventArgs>))
            return new System.Action<UnityEngine.Experimental.XR.ReferencePointUpdatedEventArgs>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Experimental.XR.SessionTrackingStateChangedEventArgs>))
            return new System.Action<UnityEngine.Experimental.XR.SessionTrackingStateChangedEventArgs>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Font>))
            return new System.Action<UnityEngine.Font>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Playables.PlayableDirector>))
            return new System.Action<UnityEngine.Playables.PlayableDirector>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Profiling.Memory.Experimental.MetaData>))
            return new System.Action<UnityEngine.Profiling.Memory.Experimental.MetaData>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent>))
            return new System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>))
            return new System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.Scripting.GarbageCollector.Mode>))
            return new System.Action<UnityEngine.Scripting.GarbageCollector.Mode>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.SocialPlatforms.IAchievement[]>))
            return new System.Action<UnityEngine.SocialPlatforms.IAchievement[]>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>))
            return new System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.SocialPlatforms.IScore[]>))
            return new System.Action<UnityEngine.SocialPlatforms.IScore[]>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.SocialPlatforms.IUserProfile[]>))
            return new System.Action<UnityEngine.SocialPlatforms.IUserProfile[]>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.U2D.SpriteAtlas>))
            return new System.Action<UnityEngine.U2D.SpriteAtlas>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngine.XR.XRNodeState>))
            return new System.Action<UnityEngine.XR.XRNodeState>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<UnityEngineInternal.Input.NativeInputUpdateType>))
            return new System.Action<UnityEngineInternal.Input.NativeInputUpdateType>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.AsyncCallback))
            return new System.AsyncCallback( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Func<System.Boolean>))
            return new System.Func<System.Boolean>( () => { return scriptObject.call(ScriptValue.Null).IsTrue; } );
        if (delegateType == typeof(System.Func<TMPro.KerningPair,System.UInt32>))
            return new System.Func<TMPro.KerningPair,System.UInt32>( (arg0) => { return (System.UInt32)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0).Value, typeof(System.UInt32)); } );
        if (delegateType == typeof(System.Func<TMPro.TMP_Character,System.UInt32>))
            return new System.Func<TMPro.TMP_Character,System.UInt32>( (arg0) => { return (System.UInt32)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0).Value, typeof(System.UInt32)); } );
        if (delegateType == typeof(System.Func<TMPro.TMP_GlyphPairAdjustmentRecord,System.UInt32>))
            return new System.Func<TMPro.TMP_GlyphPairAdjustmentRecord,System.UInt32>( (arg0) => { return (System.UInt32)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0).Value, typeof(System.UInt32)); } );
        if (delegateType == typeof(System.Func<TMPro.TMP_SpriteCharacter,System.UInt32>))
            return new System.Func<TMPro.TMP_SpriteCharacter,System.UInt32>( (arg0) => { return (System.UInt32)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0).Value, typeof(System.UInt32)); } );
        if (delegateType == typeof(System.Func<TMPro.TMP_SpriteGlyph,System.UInt32>))
            return new System.Func<TMPro.TMP_SpriteGlyph,System.UInt32>( (arg0) => { return (System.UInt32)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0).Value, typeof(System.UInt32)); } );
        if (delegateType == typeof(System.Func<UnityEngine.TextCore.Glyph,System.UInt32>))
            return new System.Func<UnityEngine.TextCore.Glyph,System.UInt32>( (arg0) => { return (System.UInt32)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0).Value, typeof(System.UInt32)); } );
        if (delegateType == typeof(System.Func<UnityEngine.UI.ILayoutElement,System.Single>))
            return new System.Func<UnityEngine.UI.ILayoutElement,System.Single>( (arg0) => { return (System.Single)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0).Value, typeof(System.Single)); } );
        if (delegateType == typeof(TimerCallBack))
            return new TimerCallBack( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(TMPro.TMP_InputField.OnValidateInput))
            return new TMPro.TMP_InputField.OnValidateInput( (arg0,arg1,arg2) => { return (System.Char)scriptObject.call(ScriptValue.Null,arg0,arg1,arg2).Value; } );
        if (delegateType == typeof(UnityEngine.AI.NavMesh.OnNavMeshPreUpdate))
            return new UnityEngine.AI.NavMesh.OnNavMeshPreUpdate( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChanged))
            return new UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChanged( (arg0,arg1,arg2,arg3) => { scriptObject.call(ScriptValue.Null,arg0,arg1,arg2,arg3); } );
        if (delegateType == typeof(UnityEngine.AndroidJavaRunnable))
            return new UnityEngine.AndroidJavaRunnable( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(UnityEngine.Application.AdvertisingIdentifierCallback))
            return new UnityEngine.Application.AdvertisingIdentifierCallback( (arg0,arg1,arg2) => { scriptObject.call(ScriptValue.Null,arg0,arg1,arg2); } );
        if (delegateType == typeof(UnityEngine.Application.LogCallback))
            return new UnityEngine.Application.LogCallback( (arg0,arg1,arg2) => { scriptObject.call(ScriptValue.Null,arg0,arg1,arg2); } );
        if (delegateType == typeof(UnityEngine.Application.LowMemoryCallback))
            return new UnityEngine.Application.LowMemoryCallback( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(UnityEngine.AudioClip.PCMReaderCallback))
            return new UnityEngine.AudioClip.PCMReaderCallback( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.AudioClip.PCMSetPositionCallback))
            return new UnityEngine.AudioClip.PCMSetPositionCallback( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.AudioSettings.AudioConfigurationChangeHandler))
            return new UnityEngine.AudioSettings.AudioConfigurationChangeHandler( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Camera.CameraCallback))
            return new UnityEngine.Camera.CameraCallback( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Canvas.WillRenderCanvases))
            return new UnityEngine.Canvas.WillRenderCanvases( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(UnityEngine.CullingGroup.StateChanged))
            return new UnityEngine.CullingGroup.StateChanged( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Display.DisplaysUpdatedDelegate))
            return new UnityEngine.Display.DisplaysUpdatedDelegate( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction))
            return new UnityEngine.Events.UnityAction( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<System.Boolean>))
            return new UnityEngine.Events.UnityAction<System.Boolean>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<System.Int32>))
            return new UnityEngine.Events.UnityAction<System.Int32>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<System.Single>))
            return new UnityEngine.Events.UnityAction<System.Single>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<System.String,System.Int32,System.Int32>))
            return new UnityEngine.Events.UnityAction<System.String,System.Int32,System.Int32>( (arg0,arg1,arg2) => { scriptObject.call(ScriptValue.Null,arg0,arg1,arg2); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<System.String>))
            return new UnityEngine.Events.UnityAction<System.String>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<UnityEngine.Color>))
            return new UnityEngine.Events.UnityAction<UnityEngine.Color>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>))
            return new UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>))
            return new UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode>))
            return new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene>))
            return new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>))
            return new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<UnityEngine.TouchScreenKeyboard.Status>))
            return new UnityEngine.Events.UnityAction<UnityEngine.TouchScreenKeyboard.Status>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Events.UnityAction<UnityEngine.Vector2>))
            return new UnityEngine.Events.UnityAction<UnityEngine.Vector2>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>))
            return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.Experimental.Audio.AudioSampleProvider.ConsumeSampleFramesNativeFunction))
            return new UnityEngine.Experimental.Audio.AudioSampleProvider.ConsumeSampleFramesNativeFunction( (arg0,arg1,arg2) => { return (System.UInt32)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0,arg1,arg2).Value, typeof(System.UInt32)); } );
        if (delegateType == typeof(UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesEventNativeFunction))
            return new UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesEventNativeFunction( (arg0,arg1,arg2) => { scriptObject.call(ScriptValue.Null,arg0,arg1,arg2); } );
        if (delegateType == typeof(UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler))
            return new UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate))
            return new UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.Experimental.LowLevel.PlayerLoopSystem.UpdateFunction))
            return new UnityEngine.Experimental.LowLevel.PlayerLoopSystem.UpdateFunction( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap.TerrainFilter))
            return new UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap.TerrainFilter( (arg0) => { return scriptObject.call(ScriptValue.Null,arg0).IsTrue; } );
        if (delegateType == typeof(UnityEngine.Font.FontTextureRebuildCallback))
            return new UnityEngine.Font.FontTextureRebuildCallback( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(UnityEngine.GUI.WindowFunction))
            return new UnityEngine.GUI.WindowFunction( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Networking.NetworkBehaviour.CmdDelegate))
            return new UnityEngine.Networking.NetworkBehaviour.CmdDelegate( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.Networking.NetworkMessageDelegate))
            return new UnityEngine.Networking.NetworkMessageDelegate( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.RectTransform.ReapplyDrivenProperties))
            return new UnityEngine.RectTransform.ReapplyDrivenProperties( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.RemoteSettings.UpdatedEventHandler))
            return new UnityEngine.RemoteSettings.UpdatedEventHandler( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(UnityEngine.UI.InputField.OnValidateInput))
            return new UnityEngine.UI.InputField.OnValidateInput( (arg0,arg1,arg2) => { return (System.Char)scriptObject.call(ScriptValue.Null,arg0,arg1,arg2).Value; } );
        if (delegateType == typeof(UnityEngine.Video.VideoPlayer.ErrorEventHandler))
            return new UnityEngine.Video.VideoPlayer.ErrorEventHandler( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.Video.VideoPlayer.EventHandler))
            return new UnityEngine.Video.VideoPlayer.EventHandler( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler))
            return new UnityEngine.Video.VideoPlayer.FrameReadyEventHandler( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(UnityEngine.Video.VideoPlayer.TimeEventHandler))
            return new UnityEngine.Video.VideoPlayer.TimeEventHandler( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        // if (delegateType == typeof(UnityEngineInternal.Input.NativeUpdateCallback))
        //     return new UnityEngineInternal.Input.NativeUpdateCallback( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(YieldCallback))
            return new YieldCallback( () => { scriptObject.call(ScriptValue.Null); } );
        throw new Exception("Delegate Type is not found : " + delegateType + "  scriptObject : " + scriptObject);
    }
}