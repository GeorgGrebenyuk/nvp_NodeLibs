using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an instance of an external reference inserted into a drawing
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadExternalReference 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadExternalReference_Constructor : INode 
	{
		public OdaX.IAcadExternalReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadExternalReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadExternalReference_ConstructorCast : INode 
	{
		public OdaX.IAcadExternalReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadExternalReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the source path of an external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadExternalReference", typeof(object))]

	///<summary>
	///Specifies or returns the source path of an external reference.
	///</summary>
	public class Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Path);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the source path of an external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadExternalReference", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the source path of an external reference.
	///</summary>
	public class Set_Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Path = inputs[1].Value;
			return null;
		}
	}
}
