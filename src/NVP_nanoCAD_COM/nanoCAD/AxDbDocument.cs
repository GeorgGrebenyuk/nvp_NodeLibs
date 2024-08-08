using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Provides access to database without document.
///</summary>
namespace nanoCAD.AxDbDocument 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AxDbDocument_Constructor : INode 
	{
		public nanoCAD.IAxDbDocument _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IAxDbDocument;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AxDbDocument_ConstructorCast : INode 
	{
		public nanoCAD.IAxDbDocument _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IAxDbDocument;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the document", 
		ViewType = "Data")]
	[NodeInput("AxDbDocument", typeof(object))]

	///<summary>
	///Specifies the name of the document
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
		Text = "Specifies the name of the document", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies the name of the document
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Opens document.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("Password", typeof(System.Object))]

	///<summary>
	///Opens document.
	///</summary>
	public class Open : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Open(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Saves document.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]

	///<summary>
	///Saves document.
	///</summary>
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Saves document with new name.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("vSecurityParams", typeof(System.Object))]

	///<summary>
	///Saves document with new name.
	///</summary>
	public class SaveAs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAs(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "DxfIn.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("LogFileName", typeof(System.Object))]

	///<summary>
	///DxfIn.
	///</summary>
	public class DxfIn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DxfIn(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "DxfOut.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("precision", typeof(System.Object))]
	[NodeInput("SaveThumbnailImage", typeof(System.Object))]

	///<summary>
	///DxfOut.
	///</summary>
	public class DxfOut : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DxfOut(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves an Application object", 
		ViewType = "Data")]
	[NodeInput("AxDbDocument", typeof(object))]

	///<summary>
	///Retrieves an Application object
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves an database object", 
		ViewType = "Data")]
	[NodeInput("AxDbDocument", typeof(object))]

	///<summary>
	///Retrieves an database object
	///</summary>
	public class Database : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Database);

		}
	}
}
