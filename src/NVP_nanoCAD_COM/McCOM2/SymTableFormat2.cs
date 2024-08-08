using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table item formatter
///</summary>
namespace McCOM2.SymTableFormat2 
{

	[NVP_Manifest(
		Id = "8A24F0D1-5BAA-4CE1-AB2F-B4F0368461C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat2.SymTableFormat2_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat2", 
		NodeName = "_SymTableFormat2_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableFormat2_Constructor : INode 
	{
		public McCOM2.ISymTableFormat2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTableFormat2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "320D66D5-8D5A-46F6-96FF-C338CE5EC2E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat2.SymTableFormat2_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat2", 
		NodeName = "_SymTableFormat2_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableFormat2_ConstructorCast : INode 
	{
		public McCOM2.ISymTableFormat2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTableFormat2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "05D3C48C-E276-4690-AA30-01F0D7F382D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat2.VertFit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat2", 
		NodeName = "VertFit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000060a", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat2", typeof(object))]

	///<summary>
	///0x0000060a
	///</summary>
	public class VertFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VertFit);

		}
	}


	[NVP_Manifest(
		Id = "E57D3DB2-9B2F-43E0-9EBB-4D33D650ADD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat2.Set_VertFit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat2", 
		NodeName = "Set_VertFit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000060a", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat2", typeof(object))]
	[NodeInput("McCOM2.SymTableVertFit", typeof(System.Object))]

	///<summary>
	///0x0000060a
	///</summary>
	public class Set_VertFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VertFit = ((McCOM2.SymTableVertFit)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BC3B03B4-D9EF-49F9-B7FF-F61DD27391F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat2.HorzFit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat2", 
		NodeName = "HorzFit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000060b", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat2", typeof(object))]

	///<summary>
	///0x0000060b
	///</summary>
	public class HorzFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorzFit);

		}
	}


	[NVP_Manifest(
		Id = "A6C57677-4FC9-4E19-B022-DEEDD6B52882", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat2.Set_HorzFit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat2", 
		NodeName = "Set_HorzFit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000060b", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat2", typeof(object))]
	[NodeInput("McCOM2.SymTableHorzFit", typeof(System.Object))]

	///<summary>
	///0x0000060b
	///</summary>
	public class Set_HorzFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorzFit = ((McCOM2.SymTableHorzFit)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "05B2F5A3-DE28-4E68-B179-2E5BF11307DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat2.FillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat2", 
		NodeName = "FillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000060c", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat2", typeof(object))]

	///<summary>
	///0x0000060c
	///</summary>
	public class FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FillColor);

		}
	}


	[NVP_Manifest(
		Id = "98BAB437-2E2B-48EF-93D8-0B714B8FCBE8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat2.Set_FillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat2", 
		NodeName = "Set_FillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000060c", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat2", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000060c
	///</summary>
	public class Set_FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FillColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AEE8ADC1-CFB8-41FE-9AC5-29FFA231646E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat2.ReadOnly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat2", 
		NodeName = "ReadOnly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000612", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat2", typeof(object))]

	///<summary>
	///0x00000612
	///</summary>
	public class ReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReadOnly);

		}
	}
}
