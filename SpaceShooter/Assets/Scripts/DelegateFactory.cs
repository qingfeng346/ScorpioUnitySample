using System;
using System.Collections.Generic;
using Scorpio;
public class DelegateFactory : IDelegateFactory {
    public static void Initialize(Script script) {
        ScorpioDelegateFactory.SetFactory(new DelegateFactory());
        script.SetGlobal("System.Action", ScriptValue.CreateValue(typeof(System.Action)));
        script.SetGlobal("System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>>", ScriptValue.CreateValue(typeof(System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>>)));
        script.SetGlobal("System.Action<System.Boolean,System.Boolean,System.Int32>", ScriptValue.CreateValue(typeof(System.Action<System.Boolean,System.Boolean,System.Int32>)));
        script.SetGlobal("System.Action<System.Boolean,System.String>", ScriptValue.CreateValue(typeof(System.Action<System.Boolean,System.String>)));
        script.SetGlobal("System.Action<System.Boolean>", ScriptValue.CreateValue(typeof(System.Action<System.Boolean>)));
        script.SetGlobal("System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>", ScriptValue.CreateValue(typeof(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>)));
        script.SetGlobal("System.Action<System.Int32,System.String>", ScriptValue.CreateValue(typeof(System.Action<System.Int32,System.String>)));
        script.SetGlobal("System.Action<System.String,System.Action<UnityEngine.U2D.SpriteAtlas>>", ScriptValue.CreateValue(typeof(System.Action<System.String,System.Action<UnityEngine.U2D.SpriteAtlas>>)));
        script.SetGlobal("System.Action<System.String,System.Boolean>", ScriptValue.CreateValue(typeof(System.Action<System.String,System.Boolean>)));
        script.SetGlobal("System.Action<UnityEngine.AsyncOperation>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.AsyncOperation>)));
        script.SetGlobal("System.Action<UnityEngine.Camera[]>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Camera[]>)));
        script.SetGlobal("System.Action<UnityEngine.Camera>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Camera>)));
        script.SetGlobal("System.Action<UnityEngine.Cubemap>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Cubemap>)));
        script.SetGlobal("System.Action<UnityEngine.Experimental.XR.FrameReceivedEventArgs>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Experimental.XR.FrameReceivedEventArgs>)));
        script.SetGlobal("System.Action<UnityEngine.Experimental.XR.MeshGenerationResult>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Experimental.XR.MeshGenerationResult>)));
        script.SetGlobal("System.Action<UnityEngine.Experimental.XR.PlaneAddedEventArgs>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Experimental.XR.PlaneAddedEventArgs>)));
        script.SetGlobal("System.Action<UnityEngine.Experimental.XR.PlaneRemovedEventArgs>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Experimental.XR.PlaneRemovedEventArgs>)));
        script.SetGlobal("System.Action<UnityEngine.Experimental.XR.PlaneUpdatedEventArgs>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Experimental.XR.PlaneUpdatedEventArgs>)));
        script.SetGlobal("System.Action<UnityEngine.Experimental.XR.PointCloudUpdatedEventArgs>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Experimental.XR.PointCloudUpdatedEventArgs>)));
        script.SetGlobal("System.Action<UnityEngine.Experimental.XR.ReferencePointUpdatedEventArgs>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Experimental.XR.ReferencePointUpdatedEventArgs>)));
        script.SetGlobal("System.Action<UnityEngine.Experimental.XR.SessionTrackingStateChangedEventArgs>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Experimental.XR.SessionTrackingStateChangedEventArgs>)));
        script.SetGlobal("System.Action<UnityEngine.Font>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Font>)));
        script.SetGlobal("System.Action<UnityEngine.Playables.PlayableDirector>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Playables.PlayableDirector>)));
        script.SetGlobal("System.Action<UnityEngine.Profiling.Memory.Experimental.MetaData>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Profiling.Memory.Experimental.MetaData>)));
        script.SetGlobal("System.Action<UnityEngine.Purchasing.InitializationFailureReason>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Purchasing.InitializationFailureReason>)));
        script.SetGlobal("System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent>)));
        script.SetGlobal("System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>)));
        script.SetGlobal("System.Action<UnityEngine.Scripting.GarbageCollector.Mode>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.Scripting.GarbageCollector.Mode>)));
        script.SetGlobal("System.Action<UnityEngine.SocialPlatforms.IAchievement[]>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.SocialPlatforms.IAchievement[]>)));
        script.SetGlobal("System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>)));
        script.SetGlobal("System.Action<UnityEngine.SocialPlatforms.IScore[]>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.SocialPlatforms.IScore[]>)));
        script.SetGlobal("System.Action<UnityEngine.SocialPlatforms.IUserProfile[]>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.SocialPlatforms.IUserProfile[]>)));
        script.SetGlobal("System.Action<UnityEngine.U2D.SpriteAtlas>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.U2D.SpriteAtlas>)));
        script.SetGlobal("System.Action<UnityEngine.XR.XRNodeState>", ScriptValue.CreateValue(typeof(System.Action<UnityEngine.XR.XRNodeState>)));
        script.SetGlobal("System.AsyncCallback", ScriptValue.CreateValue(typeof(System.AsyncCallback)));
        script.SetGlobal("System.Comparison<Scorpio.Userdata.FunctionData>", ScriptValue.CreateValue(typeof(System.Comparison<Scorpio.Userdata.FunctionData>)));
        script.SetGlobal("System.Converter<System.String,System.String>", ScriptValue.CreateValue(typeof(System.Converter<System.String,System.String>)));
        script.SetGlobal("System.Func<System.Boolean>", ScriptValue.CreateValue(typeof(System.Func<System.Boolean>)));
        script.SetGlobal("System.Func<TMPro.KerningPair,System.UInt32>", ScriptValue.CreateValue(typeof(System.Func<TMPro.KerningPair,System.UInt32>)));
        script.SetGlobal("System.Func<TMPro.TMP_Character,System.UInt32>", ScriptValue.CreateValue(typeof(System.Func<TMPro.TMP_Character,System.UInt32>)));
        script.SetGlobal("System.Func<TMPro.TMP_GlyphPairAdjustmentRecord,System.UInt32>", ScriptValue.CreateValue(typeof(System.Func<TMPro.TMP_GlyphPairAdjustmentRecord,System.UInt32>)));
        script.SetGlobal("System.Func<TMPro.TMP_SpriteCharacter,System.UInt32>", ScriptValue.CreateValue(typeof(System.Func<TMPro.TMP_SpriteCharacter,System.UInt32>)));
        script.SetGlobal("System.Func<TMPro.TMP_SpriteGlyph,System.UInt32>", ScriptValue.CreateValue(typeof(System.Func<TMPro.TMP_SpriteGlyph,System.UInt32>)));
        script.SetGlobal("System.Func<UnityEngine.Purchasing.Product,System.String>", ScriptValue.CreateValue(typeof(System.Func<UnityEngine.Purchasing.Product,System.String>)));
        script.SetGlobal("System.Func<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product>", ScriptValue.CreateValue(typeof(System.Func<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product>)));
        script.SetGlobal("System.Func<UnityEngine.TextCore.Glyph,System.UInt32>", ScriptValue.CreateValue(typeof(System.Func<UnityEngine.TextCore.Glyph,System.UInt32>)));
        script.SetGlobal("System.Func<UnityEngine.UI.ILayoutElement,System.Single>", ScriptValue.CreateValue(typeof(System.Func<UnityEngine.UI.ILayoutElement,System.Single>)));
        script.SetGlobal("System.Predicate<Scorpio.ScriptValue>", ScriptValue.CreateValue(typeof(System.Predicate<Scorpio.ScriptValue>)));
        script.SetGlobal("TimerCallBack", ScriptValue.CreateValue(typeof(TimerCallBack)));
        script.SetGlobal("TMPro.TMP_InputField.OnValidateInput", ScriptValue.CreateValue(typeof(TMPro.TMP_InputField.OnValidateInput)));
        script.SetGlobal("UnityEngine.AI.NavMesh.OnNavMeshPreUpdate", ScriptValue.CreateValue(typeof(UnityEngine.AI.NavMesh.OnNavMeshPreUpdate)));
        script.SetGlobal("UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChanged", ScriptValue.CreateValue(typeof(UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChanged)));
        script.SetGlobal("UnityEngine.AndroidJavaRunnable", ScriptValue.CreateValue(typeof(UnityEngine.AndroidJavaRunnable)));
        script.SetGlobal("UnityEngine.Application.AdvertisingIdentifierCallback", ScriptValue.CreateValue(typeof(UnityEngine.Application.AdvertisingIdentifierCallback)));
        script.SetGlobal("UnityEngine.Application.LogCallback", ScriptValue.CreateValue(typeof(UnityEngine.Application.LogCallback)));
        script.SetGlobal("UnityEngine.Application.LowMemoryCallback", ScriptValue.CreateValue(typeof(UnityEngine.Application.LowMemoryCallback)));
        script.SetGlobal("UnityEngine.AudioClip.PCMReaderCallback", ScriptValue.CreateValue(typeof(UnityEngine.AudioClip.PCMReaderCallback)));
        script.SetGlobal("UnityEngine.AudioClip.PCMSetPositionCallback", ScriptValue.CreateValue(typeof(UnityEngine.AudioClip.PCMSetPositionCallback)));
        script.SetGlobal("UnityEngine.AudioSettings.AudioConfigurationChangeHandler", ScriptValue.CreateValue(typeof(UnityEngine.AudioSettings.AudioConfigurationChangeHandler)));
        script.SetGlobal("UnityEngine.Camera.CameraCallback", ScriptValue.CreateValue(typeof(UnityEngine.Camera.CameraCallback)));
        script.SetGlobal("UnityEngine.Canvas.WillRenderCanvases", ScriptValue.CreateValue(typeof(UnityEngine.Canvas.WillRenderCanvases)));
        script.SetGlobal("UnityEngine.CullingGroup.StateChanged", ScriptValue.CreateValue(typeof(UnityEngine.CullingGroup.StateChanged)));
        script.SetGlobal("UnityEngine.Display.DisplaysUpdatedDelegate", ScriptValue.CreateValue(typeof(UnityEngine.Display.DisplaysUpdatedDelegate)));
        script.SetGlobal("UnityEngine.Events.UnityAction", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction)));
        script.SetGlobal("UnityEngine.Events.UnityAction<System.Boolean>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<System.Boolean>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<System.Int32>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<System.Int32>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<System.Single>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<System.Single>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<System.String,System.Int32,System.Int32>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<System.String,System.Int32,System.Int32>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<System.String>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<System.String>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<UnityEngine.Color>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<UnityEngine.Color>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<UnityEngine.TouchScreenKeyboard.Status>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<UnityEngine.TouchScreenKeyboard.Status>)));
        script.SetGlobal("UnityEngine.Events.UnityAction<UnityEngine.Vector2>", ScriptValue.CreateValue(typeof(UnityEngine.Events.UnityAction<UnityEngine.Vector2>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>)));
        script.SetGlobal("UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>", ScriptValue.CreateValue(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>)));
        script.SetGlobal("UnityEngine.Experimental.Audio.AudioSampleProvider.ConsumeSampleFramesNativeFunction", ScriptValue.CreateValue(typeof(UnityEngine.Experimental.Audio.AudioSampleProvider.ConsumeSampleFramesNativeFunction)));
        script.SetGlobal("UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesEventNativeFunction", ScriptValue.CreateValue(typeof(UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesEventNativeFunction)));
        script.SetGlobal("UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler", ScriptValue.CreateValue(typeof(UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler)));
        script.SetGlobal("UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate", ScriptValue.CreateValue(typeof(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate)));
        script.SetGlobal("UnityEngine.Experimental.LowLevel.PlayerLoopSystem.UpdateFunction", ScriptValue.CreateValue(typeof(UnityEngine.Experimental.LowLevel.PlayerLoopSystem.UpdateFunction)));
        script.SetGlobal("UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap.TerrainFilter", ScriptValue.CreateValue(typeof(UnityEngine.Experimental.TerrainAPI.TerrainUtility.TerrainMap.TerrainFilter)));
        script.SetGlobal("UnityEngine.Font.FontTextureRebuildCallback", ScriptValue.CreateValue(typeof(UnityEngine.Font.FontTextureRebuildCallback)));
        script.SetGlobal("UnityEngine.GUI.WindowFunction", ScriptValue.CreateValue(typeof(UnityEngine.GUI.WindowFunction)));
        script.SetGlobal("UnityEngine.Networking.NetworkBehaviour.CmdDelegate", ScriptValue.CreateValue(typeof(UnityEngine.Networking.NetworkBehaviour.CmdDelegate)));
        script.SetGlobal("UnityEngine.Networking.NetworkMessageDelegate", ScriptValue.CreateValue(typeof(UnityEngine.Networking.NetworkMessageDelegate)));
        script.SetGlobal("UnityEngine.RectTransform.ReapplyDrivenProperties", ScriptValue.CreateValue(typeof(UnityEngine.RectTransform.ReapplyDrivenProperties)));
        script.SetGlobal("UnityEngine.RemoteSettings.UpdatedEventHandler", ScriptValue.CreateValue(typeof(UnityEngine.RemoteSettings.UpdatedEventHandler)));
        script.SetGlobal("UnityEngine.UI.InputField.OnValidateInput", ScriptValue.CreateValue(typeof(UnityEngine.UI.InputField.OnValidateInput)));
        script.SetGlobal("UnityEngine.Video.VideoPlayer.ErrorEventHandler", ScriptValue.CreateValue(typeof(UnityEngine.Video.VideoPlayer.ErrorEventHandler)));
        script.SetGlobal("UnityEngine.Video.VideoPlayer.EventHandler", ScriptValue.CreateValue(typeof(UnityEngine.Video.VideoPlayer.EventHandler)));
        script.SetGlobal("UnityEngine.Video.VideoPlayer.FrameReadyEventHandler", ScriptValue.CreateValue(typeof(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler)));
        script.SetGlobal("UnityEngine.Video.VideoPlayer.TimeEventHandler", ScriptValue.CreateValue(typeof(UnityEngine.Video.VideoPlayer.TimeEventHandler)));
        script.SetGlobal("YieldCallback", ScriptValue.CreateValue(typeof(YieldCallback)));
    }
    public Delegate CreateDelegate(Type delegateType, ScriptObject scriptObject) {
        if (delegateType == typeof(System.Action))
            return new System.Action( () => { scriptObject.call(ScriptValue.Null); } );
        if (delegateType == typeof(System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>>))
            return new System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<System.Boolean,System.Boolean,System.Int32>))
            return new System.Action<System.Boolean,System.Boolean,System.Int32>( (arg0,arg1,arg2) => { scriptObject.call(ScriptValue.Null,arg0,arg1,arg2); } );
        if (delegateType == typeof(System.Action<System.Boolean,System.String>))
            return new System.Action<System.Boolean,System.String>( (arg0,arg1) => { scriptObject.call(ScriptValue.Null,arg0,arg1); } );
        if (delegateType == typeof(System.Action<System.Boolean>))
            return new System.Action<System.Boolean>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>))
            return new System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
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
        if (delegateType == typeof(System.Action<UnityEngine.Purchasing.InitializationFailureReason>))
            return new System.Action<UnityEngine.Purchasing.InitializationFailureReason>( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
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
        if (delegateType == typeof(System.AsyncCallback))
            return new System.AsyncCallback( (arg0) => { scriptObject.call(ScriptValue.Null,arg0); } );
        if (delegateType == typeof(System.Comparison<Scorpio.Userdata.FunctionData>))
            return new System.Comparison<Scorpio.Userdata.FunctionData>( (arg0,arg1) => { return (System.Int32)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0,arg1).Value, typeof(System.Int32)); } );
        if (delegateType == typeof(System.Converter<System.String,System.String>))
            return new System.Converter<System.String,System.String>( (arg0) => { return scriptObject.call(ScriptValue.Null,arg0).ToString(); } );
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
        if (delegateType == typeof(System.Func<UnityEngine.Purchasing.Product,System.String>))
            return new System.Func<UnityEngine.Purchasing.Product,System.String>( (arg0) => { return scriptObject.call(ScriptValue.Null,arg0).ToString(); } );
        if (delegateType == typeof(System.Func<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product>))
            return new System.Func<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product>( (arg0) => { return (UnityEngine.Purchasing.Product)scriptObject.call(ScriptValue.Null,arg0).Value; } );
        if (delegateType == typeof(System.Func<UnityEngine.TextCore.Glyph,System.UInt32>))
            return new System.Func<UnityEngine.TextCore.Glyph,System.UInt32>( (arg0) => { return (System.UInt32)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0).Value, typeof(System.UInt32)); } );
        if (delegateType == typeof(System.Func<UnityEngine.UI.ILayoutElement,System.Single>))
            return new System.Func<UnityEngine.UI.ILayoutElement,System.Single>( (arg0) => { return (System.Single)Convert.ChangeType(scriptObject.call(ScriptValue.Null,arg0).Value, typeof(System.Single)); } );
        if (delegateType == typeof(System.Predicate<Scorpio.ScriptValue>))
            return new System.Predicate<Scorpio.ScriptValue>( (arg0) => { return scriptObject.call(ScriptValue.Null,arg0).IsTrue; } );
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
        if (delegateType == typeof(YieldCallback))
            return new YieldCallback( () => { scriptObject.call(ScriptValue.Null); } );
        throw new Exception("Delegate Type is not found : " + delegateType + "  scriptObject : " + scriptObject);
    }
}