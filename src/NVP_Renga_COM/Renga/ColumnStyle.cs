using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ColumnStyle 
{

	[NVP_Manifest(
		Id = "DEC77A24-EC8B-43DA-A178-547A58A744C8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnStyle.ColumnStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnStyle", 
		NodeName = "_ColumnStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ColumnStyle_Constructor : INode 
	{
		public Renga.IColumnStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IColumnStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "092397A8-09F9-4A29-975C-C5D0D288CBBE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnStyle.ColumnStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnStyle", 
		NodeName = "_ColumnStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ColumnStyle_ConstructorCast : INode 
	{
		public Renga.IColumnStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IColumnStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "6F4CB5D2-E2E7-45D2-B29A-8201718C4CB7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnStyle.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnStyle", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ColumnStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "0CB3DD8B-659A-4AB5-B3BB-DE43D6560EE9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ColumnStyle", typeof(object))]

	///<summary>
	///
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
		Id = "ACC8286D-D5CA-4CF5-A639-25783B7CC8AB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnStyle.Profile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnStyle", 
		NodeName = "Profile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ColumnStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Profile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profile);

		}
	}
}
