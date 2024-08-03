using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ActionEvents 
{

	[NVP_Manifest(
		Id = "48250B52-1043-4045-B791-7EC841DB250B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ActionEvents.ActionEvents_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ActionEvents", 
		NodeName = "_ActionEvents_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ActionEvents_Constructor : INode 
	{
		public Renga._IActionEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga._IActionEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "43308CA6-06BD-4523-A9E7-F8EDD254B43A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ActionEvents.ActionEvents_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ActionEvents", 
		NodeName = "_ActionEvents_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ActionEvents_ConstructorCast : INode 
	{
		public Renga._IActionEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga._IActionEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "09B8A39A-B393-4F3E-92DE-758D51684DE2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ActionEvents.OnTriggered", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ActionEvents", 
		NodeName = "OnTriggered", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ActionEvents", typeof(object))]

	///<summary>
	///
	///</summary>
	public class OnTriggered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnTriggered();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "040BB2B5-4F1C-44CB-BC69-97A17A6F3DAB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ActionEvents.OnToggled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ActionEvents", 
		NodeName = "OnToggled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ActionEvents", typeof(object))]

	///<summary>
	///
	///</summary>
	public class OnToggled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnToggled();
			return null;
		}
	}
}
