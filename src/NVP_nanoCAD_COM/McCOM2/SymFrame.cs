using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Drawing bound interface
///</summary>
namespace McCOM2.SymFrame 
{

	[NVP_Manifest(
		Id = "639A6628-015E-4F93-9E93-5F0FA9B0A49E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFrame.SymFrame_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFrame", 
		NodeName = "_SymFrame_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymFrame_Constructor : INode 
	{
		public McCOM2.ISymFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BC5AAD1D-8A5B-4230-955E-17F84EC1C0D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFrame.SymFrame_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFrame", 
		NodeName = "_SymFrame_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymFrame_ConstructorCast : INode 
	{
		public McCOM2.ISymFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "234E015D-3C25-43DF-876A-D47840957475", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFrame.SelectFor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFrame", 
		NodeName = "SelectFor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000022e", 
		ViewType = "Modifier")]
	[NodeInput("SymFrame", typeof(object))]
	[NodeInput("rBounds", typeof(System.Object))]

	///<summary>
	///0x0000022e
	///</summary>
	public class SelectFor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectFor(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A05C8713-0034-4FC2-8CC9-B4312DC08B56", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFrame.ZoneAtPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFrame", 
		NodeName = "ZoneAtPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000230", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]
	[NodeInput("vPoint", typeof(System.Object))]

	///<summary>
	///0x00000230
	///</summary>
	public class ZoneAtPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ZoneAtPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D7522B05-C323-4486-9D60-2BE8BA324920", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFrame.Prev", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFrame", 
		NodeName = "Prev", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000023d", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]

	///<summary>
	///0x0000023d
	///</summary>
	public class Prev : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Prev);

		}
	}


	[NVP_Manifest(
		Id = "442DDC5F-513E-4F0B-ADA6-665585DD9D8D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFrame.Next", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFrame", 
		NodeName = "Next", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000023c", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]

	///<summary>
	///0x0000023c
	///</summary>
	public class Next : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Next);

		}
	}


	[NVP_Manifest(
		Id = "1A6D93E9-F06A-4F9C-A50F-12C560C03BCD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFrame.Set_Roughness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFrame", 
		NodeName = "Set_Roughness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000023f", 
		ViewType = "Modifier")]
	[NodeInput("SymFrame", typeof(object))]
	[NodeInput("ppSymbol", typeof(System.Object))]

	///<summary>
	///0x0000023f
	///</summary>
	public class Set_Roughness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Roughness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7E95248D-B1CC-46AB-8391-B9360EE7AD0C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFrame.Roughness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFrame", 
		NodeName = "Roughness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000023f", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]

	///<summary>
	///0x0000023f
	///</summary>
	public class Roughness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Roughness);

		}
	}


	[NVP_Manifest(
		Id = "3DAF29B0-BCBA-40D0-AEB1-9034778DC874", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymFrame.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymFrame", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000240", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]

	///<summary>
	///0x00000240
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}
}
