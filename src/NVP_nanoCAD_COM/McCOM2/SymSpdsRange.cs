using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Range mark
///</summary>
namespace McCOM2.SymSpdsRange 
{

	[NVP_Manifest(
		Id = "CF46F9FA-3D31-45D4-ABBD-47F68331C7C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.SymSpdsRange_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "_SymSpdsRange_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsRange_Constructor : INode 
	{
		public McCOM2.ISymSpdsRange _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsRange;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A30B8EC5-EAA8-4165-AFAC-28CCAD94C48D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.SymSpdsRange_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "_SymSpdsRange_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsRange_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsRange _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsRange;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7F8C19DE-6456-4F16-A13E-DFAFFE24ACD3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.BasePosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "BasePosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004b0", 
		ViewType = "Data")]
	[NodeInput("SymSpdsRange", typeof(object))]

	///<summary>
	///0x000004b0
	///</summary>
	public class BasePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePosition);

		}
	}


	[NVP_Manifest(
		Id = "190A3166-B2F1-45D6-81DE-57A52A9AA861", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.Set_BasePosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "Set_BasePosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004b0", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsRange", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000004b0
	///</summary>
	public class Set_BasePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EEAAE4CA-855A-47E4-B06A-B57E0423EFA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004b5", 
		ViewType = "Data")]
	[NodeInput("SymSpdsRange", typeof(object))]

	///<summary>
	///0x000004b5
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Id = "ACB368D3-CD90-4891-9BF3-83A3594857C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004b5", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsRange", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x000004b5
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8332D8AD-53CA-4529-B0D3-23765811B5FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.Upper", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "Upper", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004bf", 
		ViewType = "Data")]
	[NodeInput("SymSpdsRange", typeof(object))]

	///<summary>
	///0x000004bf
	///</summary>
	public class Upper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Upper);

		}
	}


	[NVP_Manifest(
		Id = "E6714905-BC25-4629-8D2C-7AE9D533A220", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.Set_Upper", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "Set_Upper", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004bf", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsRange", typeof(object))]
	[NodeInput("pvValue", typeof(System.Object))]

	///<summary>
	///0x000004bf
	///</summary>
	public class Set_Upper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Upper = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E82F8DF3-C5F4-4B94-AA78-E86CE2D11AD4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.Lower", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "Lower", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004bb", 
		ViewType = "Data")]
	[NodeInput("SymSpdsRange", typeof(object))]

	///<summary>
	///0x000004bb
	///</summary>
	public class Lower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lower);

		}
	}


	[NVP_Manifest(
		Id = "6D986FDB-E07D-456D-B166-14CEC5EC27B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsRange.Set_Lower", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsRange", 
		NodeName = "Set_Lower", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004bb", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsRange", typeof(object))]
	[NodeInput("pvValue", typeof(System.Object))]

	///<summary>
	///0x000004bb
	///</summary>
	public class Set_Lower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lower = inputs[1].Value;
			return null;
		}
	}
}
