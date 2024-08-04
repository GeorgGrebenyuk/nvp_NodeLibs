using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Huge radius dimension
///</summary>
namespace McCOM2.SymDimHugeRadius 
{

	[NVP_Manifest(
		Id = "85765687-F3C1-4077-BAF8-45C3CDF355CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimHugeRadius.SymDimHugeRadius_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimHugeRadius", 
		NodeName = "_SymDimHugeRadius_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimHugeRadius_Constructor : INode 
	{
		public McCOM2.ISymDimHugeRadius _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimHugeRadius;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F93FD5D7-52F6-474C-854E-E20EE752DF97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimHugeRadius.SymDimHugeRadius_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimHugeRadius", 
		NodeName = "_SymDimHugeRadius_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimHugeRadius_ConstructorCast : INode 
	{
		public McCOM2.ISymDimHugeRadius _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimHugeRadius;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "665AC9E2-2BE3-4E72-BDAE-3BE5E8BA9A8E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimHugeRadius.MeanCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimHugeRadius", 
		NodeName = "MeanCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000180", 
		ViewType = "Data")]
	[NodeInput("SymDimHugeRadius", typeof(object))]

	///<summary>
	///0x00000180
	///</summary>
	public class MeanCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MeanCenter);

		}
	}


	[NVP_Manifest(
		Id = "AC25F030-69CB-4926-B27A-7CC473464826", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimHugeRadius.Set_MeanCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimHugeRadius", 
		NodeName = "Set_MeanCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000180", 
		ViewType = "Modifier")]
	[NodeInput("SymDimHugeRadius", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000180
	///</summary>
	public class Set_MeanCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MeanCenter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8D552A32-4F8D-470C-B33A-55E0AA9389CA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimHugeRadius.BreakPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimHugeRadius", 
		NodeName = "BreakPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000172", 
		ViewType = "Data")]
	[NodeInput("SymDimHugeRadius", typeof(object))]

	///<summary>
	///0x00000172
	///</summary>
	public class BreakPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BreakPosition);

		}
	}


	[NVP_Manifest(
		Id = "C180AD4C-E69B-4DD4-B36B-92374622CA8A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimHugeRadius.Set_BreakPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimHugeRadius", 
		NodeName = "Set_BreakPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000172", 
		ViewType = "Modifier")]
	[NodeInput("SymDimHugeRadius", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000172
	///</summary>
	public class Set_BreakPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BreakPosition = inputs[1].Value;
			return null;
		}
	}
}
