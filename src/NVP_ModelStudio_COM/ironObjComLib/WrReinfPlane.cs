using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrReinfPlane Interface
///</summary>
namespace ironObjComLib.WrReinfPlane 
{

	[NVP_Manifest(
		Id = "C5FF5455-F0D8-434A-B896-0E0BAF8B3DDB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfPlane.WrReinfPlane_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfPlane", 
		NodeName = "_WrReinfPlane_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfPlane_Constructor : INode 
	{
		public ironObjComLib.IWrReinfPlane _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrReinfPlane;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "AB8BDEA3-3104-4781-92EA-502E35226AD3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfPlane.WrReinfPlane_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfPlane", 
		NodeName = "_WrReinfPlane_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfPlane_ConstructorCast : INode 
	{
		public ironObjComLib.IWrReinfPlane _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrReinfPlane;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C28D0496-F246-43F8-9335-4DCE6C8C63F8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfPlane.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfPlane", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrReinfPlane", typeof(object))]

	///<summary>
	///Параметры
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
		Id = "7DF22C25-C25F-4F7B-A9EE-FB070FC92489", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfPlane.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfPlane", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfPlane", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
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
		Id = "149EA1EB-3D65-4E2F-8FE0-BB8F7B01B14F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfPlane.ConcCover", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfPlane", 
		NodeName = "ConcCover", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ConcCover", 
		ViewType = "Data")]
	[NodeInput("WrReinfPlane", typeof(object))]

	///<summary>
	///property ConcCover
	///</summary>
	public class ConcCover : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConcCover);

		}
	}


	[NVP_Manifest(
		Id = "604D635B-46FB-4205-93E3-5E3D019E932E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfPlane.Set_ConcCover", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfPlane", 
		NodeName = "Set_ConcCover", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ConcCover", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfPlane", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ConcCover
	///</summary>
	public class Set_ConcCover : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConcCover = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "50354013-C187-4309-BB05-45658E4FECCE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfPlane.AddOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfPlane", 
		NodeName = "AddOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AddOffset", 
		ViewType = "Data")]
	[NodeInput("WrReinfPlane", typeof(object))]

	///<summary>
	///property AddOffset
	///</summary>
	public class AddOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddOffset);

		}
	}


	[NVP_Manifest(
		Id = "84B5697B-B23B-4A49-BBDF-AFF10ED1A84B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfPlane.Set_AddOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfPlane", 
		NodeName = "Set_AddOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AddOffset", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfPlane", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property AddOffset
	///</summary>
	public class Set_AddOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddOffset = inputs[1].Value;
			return null;
		}
	}
}
