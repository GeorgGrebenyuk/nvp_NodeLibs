using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrIronModifier Interface
///</summary>
namespace ironObjComLib.WrIronModifier 
{

	[NVP_Manifest(
		Id = "C2EEB334-75B2-43A8-A265-80C12E350E6A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronModifier.WrIronModifier_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronModifier", 
		NodeName = "_WrIronModifier_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronModifier_Constructor : INode 
	{
		public ironObjComLib.IWrIronModifier _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrIronModifier;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "286A2071-8668-45E2-A4A8-4814AB980762", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronModifier.WrIronModifier_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronModifier", 
		NodeName = "_WrIronModifier_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronModifier_ConstructorCast : INode 
	{
		public ironObjComLib.IWrIronModifier _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrIronModifier;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "EA62891D-56F5-4FCF-BAB8-1755CA3BBD75", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronModifier.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronModifier", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrIronModifier", typeof(object))]

	///<summary>
	///property Element
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "57EEA37C-42DA-49A4-A050-1EE8000904C2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronModifier.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronModifier", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrIronModifier", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C50D2BA2-81FF-410F-B7D2-CE49B24367D4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronModifier.Standoff", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronModifier", 
		NodeName = "Standoff", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Отступ от начала оси", 
		ViewType = "Data")]
	[NodeInput("WrIronModifier", typeof(object))]

	///<summary>
	///property Отступ от начала оси
	///</summary>
	public class Standoff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Standoff);

		}
	}


	[NVP_Manifest(
		Id = "EB536952-821D-4A6E-9B31-42E306AECDC4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronModifier.Set_Standoff", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronModifier", 
		NodeName = "Set_Standoff", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Отступ от начала оси", 
		ViewType = "Modifier")]
	[NodeInput("WrIronModifier", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Отступ от начала оси
	///</summary>
	public class Set_Standoff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Standoff = inputs[1].Value;
			return null;
		}
	}
}
