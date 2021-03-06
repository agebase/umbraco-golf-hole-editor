﻿using ClientDependency.Core;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace AgeBase.GolfHoleEditor
{
    [PropertyEditor("AgeBase.GolfHoleEditor", "AgeBase: Golf Hole Editor", "/App_Plugins/AgeBase.GolfHoleEditor/Editor.html", ValueType = "TEXT")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "/App_Plugins/AgeBase.GolfHoleEditor/Editor.js")]
    [PropertyEditorAsset(ClientDependencyType.Css, "/App_Plugins/AgeBase.GolfHoleEditor/Editor.css")]
    public class GolfHoleEditorPropertyEditor : PropertyEditor
    {
        protected override PreValueEditor CreatePreValueEditor()
        {
            return new GolfHoleEditorPreValueEditor();
        }
    }
}