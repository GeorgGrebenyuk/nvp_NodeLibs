using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IParameter Interface
///</summary>
namespace mdsUnitsLib.Parameter 
{

	[NVP_Manifest(
		Id = "07B886A8-3CFA-41D6-8BC5-4BEFED5B20CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameter.Parameter_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameter", 
		NodeName = "_Parameter_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameter_Constructor : INode 
	{
		public mdsUnitsLib.IParameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IParameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "7ED5E16A-CDFB-4523-8E6F-10413FBFF89E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameter.Parameter_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameter", 
		NodeName = "_Parameter_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameter_ConstructorCast : INode 
	{
		public mdsUnitsLib.IParameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IParameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "D0240A4A-A275-4D74-B25E-FFA5FAFB90A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameter.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameter", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///property Name
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "9575A042-7E19-4356-9773-97CAB15FEA6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameter.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameter", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Value", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///property Value
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
		Id = "E85F441C-EFF4-48B6-9AA7-7868B8658FAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameter.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameter", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Value", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Value
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
		Id = "83B49A7A-B21A-4A6B-9CA4-96C30AC7A9BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameter.Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameter", 
		NodeName = "Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Comment", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///property Comment
	///</summary>
	public class Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Comment);

		}
	}


	[NVP_Manifest(
		Id = "143394D4-94A1-49D1-A846-52236A23A291", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameter.Set_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameter", 
		NodeName = "Set_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Comment", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Comment
	///</summary>
	public class Set_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "83E188E5-7828-479B-9F33-C338C847ECB4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameter.ValueComment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameter", 
		NodeName = "ValueComment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ValueComment", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///property ValueComment
	///</summary>
	public class ValueComment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ValueComment);

		}
	}


	[NVP_Manifest(
		Id = "AF0586D7-4D38-4293-81A3-9D1CDC7BEA08", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameter.Set_ValueComment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameter", 
		NodeName = "Set_ValueComment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ValueComment", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property ValueComment
	///</summary>
	public class Set_ValueComment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ValueComment = inputs[1].Value;
			return null;
		}
	}
}
