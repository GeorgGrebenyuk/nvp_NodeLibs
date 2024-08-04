using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///s)
///</summary>
namespace McCOM2.McTransaction 
{

	[NVP_Manifest(
		Id = "1E6E2ABF-4145-4D4B-9ECC-5441B8EB4B70", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McTransaction.McTransaction_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McTransaction", 
		NodeName = "_McTransaction_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McTransaction_Constructor : INode 
	{
		public McCOM2.IMcTransaction _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IMcTransaction;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4DBC2069-A2C2-494C-8978-03B0CDD41AC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McTransaction.McTransaction_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McTransaction", 
		NodeName = "_McTransaction_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McTransaction_ConstructorCast : INode 
	{
		public McCOM2.IMcTransaction _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IMcTransaction;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "44981D8C-3D7D-4ADF-B80E-7597F634916D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McTransaction.Start", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McTransaction", 
		NodeName = "Start", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000057a", 
		ViewType = "Modifier")]
	[NodeInput("McTransaction", typeof(object))]
	[NodeInput("pObjectToWatch", typeof(System.Object))]

	///<summary>
	///0x0000057a
	///</summary>
	public class Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Start(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "70E34DA1-362E-476E-A746-3F1179E57AD4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McTransaction.Commit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McTransaction", 
		NodeName = "Commit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000578", 
		ViewType = "Modifier")]
	[NodeInput("McTransaction", typeof(object))]

	///<summary>
	///0x00000578
	///</summary>
	public class Commit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Commit();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "65A82F60-26A8-4CC2-BF07-3170664E1EDB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McTransaction.Rollback", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McTransaction", 
		NodeName = "Rollback", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000579", 
		ViewType = "Modifier")]
	[NodeInput("McTransaction", typeof(object))]

	///<summary>
	///0x00000579
	///</summary>
	public class Rollback : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rollback();
			return null;
		}
	}
}
