using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Single line of SymTolerance designation
///</summary>
namespace McCOM2.ToleranceRecord 
{

	[NVP_Manifest(
		Id = "49E20F61-7FA2-4A42-AEA6-1B09AF98B390", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.ToleranceRecord_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "_ToleranceRecord_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToleranceRecord_Constructor : INode 
	{
		public McCOM2.IToleranceRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IToleranceRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6C383B94-B3B4-4AA7-88DA-16D19B336A67", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.ToleranceRecord_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "_ToleranceRecord_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToleranceRecord_ConstructorCast : INode 
	{
		public McCOM2.IToleranceRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IToleranceRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0442A1C9-5F54-4569-A192-17F7C32F6B77", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Empty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Empty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000592", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000592
	///</summary>
	public class Empty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Empty);

		}
	}


	[NVP_Manifest(
		Id = "6B886A5D-F0DA-4AA5-8211-41749B303AA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Set_Empty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Set_Empty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000592", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceRecord", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000592
	///</summary>
	public class Set_Empty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Empty = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A88CE479-99E4-43BF-8224-A4BBB263D2A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000593", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000593
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Id = "86EE4B94-7B7D-40DB-8E5C-9EEE713765B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000593", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceRecord", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000593
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F1B93A97-C7FE-4DA8-9929-ACBC2EDCBBD8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Base", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Base", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000594", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000594
	///</summary>
	public class Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Base);

		}
	}


	[NVP_Manifest(
		Id = "5D18268B-AB9A-49E9-8D69-9A44EDD96C2A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Set_Base", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Set_Base", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000594", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceRecord", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000594
	///</summary>
	public class Set_Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Base = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0CB5BE63-AF30-45E3-9DA0-27017EC2E336", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000595", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000595
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Id = "A87328A9-7094-4E37-B897-10247A3FB64D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000595", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceRecord", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000595
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3C653DBF-50F0-43F9-B484-6D2AE91EA407", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Parameters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Parameters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000596", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000596
	///</summary>
	public class Parameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parameters);

		}
	}


	[NVP_Manifest(
		Id = "A75B43EF-8E2D-4EAD-BA85-FAEB7CCE1C63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceRecord.Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceRecord", 
		NodeName = "Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000597", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000597
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}
}
