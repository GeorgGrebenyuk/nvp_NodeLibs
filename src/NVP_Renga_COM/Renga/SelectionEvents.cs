using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.SelectionEvents 
{

	[NVP_Manifest(
		Id = "37C63A13-9021-456F-8E95-D55CE6153763", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SelectionEvents.SelectionEvents_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SelectionEvents", 
		NodeName = "_SelectionEvents_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SelectionEvents_Constructor : INode 
	{
		public Renga._ISelectionEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga._ISelectionEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E8E86A83-9007-480A-B408-ADB75815B72B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SelectionEvents.SelectionEvents_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SelectionEvents", 
		NodeName = "_SelectionEvents_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SelectionEvents_ConstructorCast : INode 
	{
		public Renga._ISelectionEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga._ISelectionEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7B6914B3-E076-49BE-A08E-B4A906F39833", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SelectionEvents.OnModelSelectionChanged", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SelectionEvents", 
		NodeName = "OnModelSelectionChanged", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("SelectionEvents", typeof(object))]

	///<summary>
	///
	///</summary>
	public class OnModelSelectionChanged : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnModelSelectionChanged();
			return null;
		}
	}
}
