using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IParameter Interface
///</summary>
namespace mdsLINEComLib.Parameter 
{

	[NVP_Manifest(
		Id = "691BE753-C4EB-4535-AAB7-ECD2EB2BF930", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameter.Parameter_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameter", 
		NodeName = "_Parameter_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameter_Constructor : INode 
	{
		public mdsLINEComLib.IParameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IParameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "01FBCD33-06E3-4086-B551-6D55AAA2FB06", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameter.Parameter_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameter", 
		NodeName = "_Parameter_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameter_ConstructorCast : INode 
	{
		public mdsLINEComLib.IParameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IParameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E2764C58-D850-4943-A4C3-8ED9867798B9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameter.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameter", 
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
		Id = "A174D3EF-2C07-42AA-B2FE-0B4FD538770B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameter.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameter", 
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
		Id = "788CA236-3163-491E-A80E-506EDE143E76", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameter.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameter", 
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
		Id = "DDDFDAD4-39D3-4E16-977A-96FAD0BC9762", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameter.Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameter", 
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
		Id = "DE597155-6346-4E50-B170-EB833AA29385", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameter.Set_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameter", 
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
		Id = "A467CAE1-AD00-4512-BDCA-90A0C48723B5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameter.ValueComment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameter", 
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
		Id = "8AA2D1FC-F8D2-425C-9FB0-9DEE89B8D3A9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameter.Set_ValueComment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameter", 
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
